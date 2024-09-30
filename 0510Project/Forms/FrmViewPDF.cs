using _0510Project.Properties;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace _0510Project.Forms
{
    public partial class FrmViewPDF : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private string pdfAddress;

        public FrmViewPDF(string pdfAddressCome)
        {
            InitializeComponent();
            pdfAddress = pdfAddressCome;
        }

        private void FrmViewPDF_Load(object sender, EventArgs e)
        {
            btnExit.IconChar = IconChar.ArrowRightFromBracket;

            if (!Settings.Default.ViewPDFWebView2)
            {
                OpenGoogleDrive(pdfAddress);

                lbViewBrowser.Visible = true;
            }
            else
            {
                try
                {
                    webShow.Source = new Uri(pdfAddress);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenGoogleDrive(string URL)
        {
            AbrirUrlEnNavegador(URL);
        }

        private void AbrirUrlEnNavegador(string url)
        {
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
                MessageBox.Show($"Ocurrió un error al intentar abrir la URL: {ex.Message}");
            }
        }
    }
}
