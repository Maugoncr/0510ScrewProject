using _0510Project.Forms;
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
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Control = System.Windows.Forms.Control;
using Label = System.Windows.Forms.Label;
using Logica.Models;
using Logica.Logic;
using _0510Project.Properties;

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

            InitializeLabelEvents();
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
            ResetAppereance();

            
        }

        private void ResetAppereance()
        {
            lbDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            btnExit.IconChar = IconChar.ArrowRightFromBracket;

           // picISOView.Image = Properties.Resources.PlaceHolderImage;
           // picTopView.Image = Properties.Resources.PlaceHolderImage;
            picLength.Image = null;

            lbAbbreviation.Text = "---";
            lbMaterial.Text = "---";
            lbNToolc.Text = "---";

            pSizeSelect.Enabled = false;
            pLengths.Enabled = false;

            btnPDF.Enabled = false;
            btnSTP.Enabled = false;

            foreach (Control control in pSizeSelect.Controls)
            {
                if (control is Label && control.Name.StartsWith("s"))
                {
                    control.BackColor = Color.White;
                }
            }


        }

       
      

      

      

        private void cbDriveType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbScrewTypes.SelectedItem.ToString() == "Socket Head Screw")
            {
                picISOView.Visible = true;
                //picISOView.Image = Properties.Resources.Socket;

                picTopView.Visible = true;
                //picTopView.Image = Properties.Resources.SocketTop;

                lbAbbreviation.Text = "SOC HD";

                lbMaterial.Text = "SST";

                lbNToolc.Text = "--- Number";

                //picLength.Image = Properties.Resources.LengthSocketHead;
            }

            if (cbScrewTypes.SelectedItem.ToString() == "Countersunk Screw")
            {
                picISOView.Visible = true;
              //  picISOView.Image = Properties.Resources.SunkISO;

                picTopView.Visible = true;
              //  picTopView.Image = Properties.Resources.SunkTop;

                lbAbbreviation.Text = "CS";

                lbMaterial.Text = "SST";

                lbNToolc.Text = "N° ---";

               // picLength.Image = Properties.Resources.LengthSunk;
            }

            if (cbScrewTypes.SelectedItem.ToString() == "Torx Screw")
            {
                picISOView.Visible = true;
//picISOView.Image = Properties.Resources.TorxISO;

                picTopView.Visible = true;
              //  picTopView.Image = Properties.Resources.TorxTop;

                lbAbbreviation.Text = "T";

                lbMaterial.Text = "SST";

                lbNToolc.Text = "N° ---";

              //  picLength.Image = Properties.Resources.LengthTorx;
            }

            if (cbScrewTypes.SelectedItem.ToString() == "Vent Socket Head Screw")
            {
                picISOView.Visible = true;
              //  picISOView.Image = Properties.Resources.VentISO;

                picTopView.Visible = true;
              //  picTopView.Image = Properties.Resources.VentTop;

                lbAbbreviation.Text = "V SOC HD";

                lbMaterial.Text = "SST";

                lbNToolc.Text = "N° ---";

//picLength.Image = Properties.Resources.LengthVent;
            }

            pSizeSelect.Enabled = true;

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

        // Manera rapida de asociar controles al evento click que necesitamos para realizar la funcionalidad de selección
        private void InitializeLabelEvents()
        {
            for (int i = 1; i <= 16; i++)
            {
                var label = pLengths.Controls.Find($"c{i}", true).FirstOrDefault() as Label;
                if (label != null) label.Click += SelectColumnLength;

                var labelA = pLengths.Controls.Find($"c{i}a", true).FirstOrDefault() as Label;
                if (labelA != null) labelA.Click += SelectColumnLength;

                var labelB = pLengths.Controls.Find($"c{i}b", true).FirstOrDefault() as Label;
                if (labelB != null) labelB.Click += SelectColumnLength;
            }

            for (int i = 0; i <= 10; i++)
            {
                var label = pSizeSelect.Controls.Find($"s{i}", true).FirstOrDefault() as Label;
                if (label != null) label.Click += SelectColumnSize;
            }
        }

        // Función que recibe un control label, este se pinta de amarillo y posteriormente se pintan de blanco todos los demás controles label para mostrar un
        // esencia de estar seleccionando labels
        private void SelectColumnSize(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                clickedLabel.BackColor = Color.Yellow;

                pLengths.Enabled = true;

                foreach (Control control in pSizeSelect.Controls)
                {
                    if (control is Label && control.Name.Contains("s") && control.Name != clickedLabel.Name)
                    {
                        control.BackColor = Color.White;
                    }
                }
            }
        }

        private void SelectColumnLength(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                string input = clickedLabel.Name.Trim('a', 'b');

                PaintSelectedColumn(input);
                DeselectOtherLength(input);

                btnPDF.Enabled = true;
                btnSTP.Enabled = true;
            }
        }

        private void PaintSelectedColumn(string inputColumn)
        {
            foreach ( Control control in pLengths.Controls)
            {
                if (control is Label && (control.Name == inputColumn || control.Name == $"{inputColumn}a" || control.Name == $"{inputColumn}b"))
                {
                    control.BackColor = Color.Yellow;
                }
            }
        }

        private void DeselectOtherLength(string baseName)
        {
            string result = baseName.Replace("c", "");

            foreach (Control control in pLengths.Controls)
            {
                if (control is Label && control.Name.StartsWith("c") && !(control.Name == $"c{result}" || control.Name == $"c{result}a" || control.Name == $"c{result}b"))
                {
                    control.BackColor = Color.White;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAppereance();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            FrmViewPDF frmScale = new FrmViewPDF("https://drive.google.com/file/d/14ZVIqs6Lp-E-Qg7wtM1tgMs1xVekFcEn/view?usp=drive_link");
            frmScale.ShowDialog();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.X)
            {
                pGestion.Visible = true;

                int formWidth = 1920;
                int formHeight = 1080;

                // Dimensiones del panel
                int panelWidth = 900;
                int panelHeight = 300;

                // Calcular la posición central
                int centerX = (formWidth - panelWidth) / 2;
                int centerY = (formHeight - panelHeight) / 2;

                // Establecer la nueva ubicación del panel
                pGestion.Location = new Point(centerX, centerY);
            }
        }

        private void btnEnterGestion_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == Settings.Default.GestionDB)
            {
                using (FrmMainManagementDB frm = new FrmMainManagementDB())
                {
                    pGestion.Visible = false;
                    frm.ShowDialog();
                }
            }
            else
            {
                pGestion.Visible = false;
                MessageBox.Show("Access denied.\nPlease verify your information or contact support if you believe you should have access to this section", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pGestion.Visible = false;
            txtPassword.Text = "";
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                e.Handled = true;
            }
        }
    }
}
