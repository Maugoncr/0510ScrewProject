using _0510Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace _0510Project.Forms
{
    public partial class FrmUpdateDataBase : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmUpdateDataBase()
        {
            InitializeComponent();
        }

        private void FrmUpdateDataBase_Load(object sender, EventArgs e)
        {
            lbWhoAreYou.Text = "User: " + GetUserName() + "\nSystem: " + GetMachineName() + "\nIP: " + GetIPAddress()
                + "\nOS: " + GetOSVersion() + "\nUserDomain: " + GetUserDomain();

            btnCheckUpdate.IconChar = FontAwesome.Sharp.IconChar.Rotate;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GetUserDomain()
        {
            return Environment.UserDomainName;
        }

        public static string GetUserName()
        {
            return Environment.UserName;
        }

        public static string GetOSVersion()
        {
            return Environment.OSVersion.ToString();
        }

        public static string GetMachineName()
        {
            return Environment.MachineName;
        }

        public static string GetIPAddress()
        {
            string hostName = Dns.GetHostName(); // Obtener el nombre del host
            IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                if (addr[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return addr[i].ToString();
                }
            }

            return "No IP Address Found";
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDownloadDataBase_Click(object sender, EventArgs e)
        {
            string url = "https://drive.google.com/drive/folders/1xpLU6qajLzntpgLekF8mazwrzETLhNgL?usp=drive_link";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            string downloadFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            string fileName = "0510Project.db";
            string filePath = Path.Combine(downloadFolderPath, fileName);

            if (File.Exists(filePath))
            {
                string oldDbPath = Settings.Default.DBPath;
                string newDbPath = filePath;

                if (File.Exists(oldDbPath) && File.Exists(newDbPath))
                {
                    DateTime oldDbDate = File.GetLastWriteTime(oldDbPath);
                    DateTime newDbDate = File.GetLastWriteTime(newDbPath);

                    if (newDbDate > oldDbDate)
                    {
                        File.Delete(oldDbPath);
                        File.Move(newDbPath, oldDbPath);

                        MessageBox.Show("The database was updated successfully.", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No changes were made; the database is already up to date..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("One or both databases do not exist in the required paths", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The downloaded database is not in the requested folder\nPlease review the instructions again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string keySequence = "";
        private readonly string desiredSequence = "ADMINMGMDB";

        private void FrmUpdateDataBase_KeyDown(object sender, KeyEventArgs e)
        {
            keySequence += (char)e.KeyValue;

            // Verifica si la secuencia actual termina con la secuencia deseada
            if (keySequence.EndsWith(desiredSequence))
            {
                btnGetActualDataBase.Visible = true;
                lbAdmin.Visible = true;
                keySequence = "";
            }
            else if (keySequence.Length > desiredSequence.Length)
            {
                keySequence = keySequence.Substring(keySequence.Length - desiredSequence.Length);
            }
        }

        private void btnGetActualDataBase_Click(object sender, EventArgs e)
        {
            // Verificar si el archivo en la ruta existe
            if (File.Exists(Settings.Default.DBPath))
            {
                // Crear un diálogo para seleccionar el destino
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Select where to save the file.";
                saveFileDialog.Filter = "All files (*.*)|*.*";
                saveFileDialog.FileName = Path.GetFileName(Settings.Default.DBPath); // Sugerir el mismo nombre

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    try
                    {
                        // Copiar el archivo desde la ruta fija
                        File.Copy(Settings.Default.DBPath, destinationFilePath, true);
                        MessageBox.Show("File copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error copying the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("The source file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
