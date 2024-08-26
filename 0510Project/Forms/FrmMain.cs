using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _0510Project
{
    public partial class FrmMain : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        public FrmMain()
        {
            InitializeComponent();
        }

        private void tDateTime_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFormSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnExit.IconChar = IconChar.ArrowRightFromBracket;
            picSocket.Visible = false;
            picSunk.Visible = false;
            picTorx.Visible = false;

            picLengthSocketHead.Visible = false;
            picLengthSunk.Visible = false;
            picLengthTorx.Visible = false;

            panel1.Visible = false;
            panel2.Visible = false;

            btnPDF.Visible = false;
            btnSTP.Visible = false;
        }

        private void cbDriveType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDriveType.SelectedItem.ToString() == "Socket Head Screw")
            {
                picSocket.Visible = true;
                picSunk.Visible = false;
                picTorx.Visible = false;

                picLengthSocketHead.Visible = true;
                picLengthSunk.Visible = false;
                picLengthTorx.Visible = false;

                btnPDF.Visible = true;
                btnSTP.Visible = true;

                panel2.Visible = true;
            }

            if (cbDriveType.SelectedItem.ToString() == "Countersunk Screw")
            {
                picSocket.Visible = false;
                picSunk.Visible = true;
                picTorx.Visible = false;

                picLengthSocketHead.Visible = false;
                picLengthSunk.Visible = true;
                picLengthTorx.Visible = false;

                btnPDF.Visible = true;
                btnSTP.Visible = true;

                panel2.Visible = true;
            }

            if (cbDriveType.SelectedItem.ToString() == "Torx Screw")
            {
                picSocket.Visible = false;
                picSunk.Visible = false;
                picTorx.Visible = true;

                picLengthSocketHead.Visible = false;
                picLengthSunk.Visible = false;
                picLengthTorx.Visible = true;

                btnPDF.Visible = true;
                btnSTP.Visible = true;

                panel2.Visible = true;
            }

        }

        private void txtSearchSize_TextChanged(object sender, EventArgs e)
        {
            // Supongamos que tienes una lista original de elementos
            List<string> allItems = new List<string>() { "0-80", "1-64", "1-72", "2-56", "2-64", "3-48", "3-56", "4-40" };

            // Filtrar los elementos en base al texto ingresado
            var filteredItems = allItems.Where(item => item.Contains(txtSearchSize.Text)).ToList();

            // Actualizar los ítems del ListBox
            listSize.DataSource = filteredItems;
        }

        private void txtSearchLength_TextChanged(object sender, EventArgs e)
        {
            // Supongamos que tienes una lista original de elementos
            List<string> allItems = new List<string>() {
                "X",
                "1/4\"",
                "3/8\"",
                "1/2\"",
                "5/8\"",
                "3/4\"",
                "7/8\"",
                "1\"",
                "1\" X",
                "1\" 1/4",
                "1\" 3/8",
                "1\" 1/2",
                "1\" 5/8",
                "1\" 3/4"
            };

            // Filtrar los elementos en base al texto ingresado
            var filteredItems = allItems.Where(item => item.Contains(txtSearchLength.Text)).ToList();

            // Actualizar los ítems del ListBox
            listLength.DataSource = filteredItems;
        }

        private void txtSearchSize_Click(object sender, EventArgs e)
        {
            txtSearchSize.SelectAll();
        }

        private void txtSearchLength_Click(object sender, EventArgs e)
        {
            txtSearchLength.SelectAll();
        }

        private void listLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLength.SelectedItem.ToString() == "1/4\"")
            {
               

            }
        }

        bool first = true;
        private void iconButton4_Click(object sender, EventArgs e)
        {

            if (first)
            {
                panel1.Visible = true;

                webBrowser1.Navigate("C:\\Users\\maugo\\source\\repos\\0510Project\\0510Project\\FilesPDF\\Test.pdf");
                first = false;
            }
            else
            {
                panel1.Visible = false;
                first = true;
            }
        }

        private void btnSTP_Click(object sender, EventArgs e)
        {
           
                // Crear una instancia de SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                // Establecer el filtro para el tipo de archivo (opcional)
                saveFileDialog.Filter = "All Files (*.*)|*.*";

                // Establecer el nombre predeterminado del archivo (opcional)
                saveFileDialog.FileName = "200-21165.STEP";

                // Mostrar el cuadro de diálogo y comprobar si el usuario hizo clic en "Guardar"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta seleccionada por el usuario
                    string destino = saveFileDialog.FileName;

                    // Ruta del archivo original
                    string rutaOrigen = "C:\\Users\\maugo\\source\\repos\\0510Project\\0510Project\\FilesPDF\\200-21165.STEP";

                    try
                    {
                        // Copiar el archivo a la ubicación seleccionada
                        System.IO.File.Copy(rutaOrigen, destino, true);

                        // Mensaje de confirmación
                        MessageBox.Show("File Saved in: " + destino, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                    }
                
            }

        }
    }
}
