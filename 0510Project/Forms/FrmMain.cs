﻿using _0510Project.Forms;
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
        
        private Screw MyScrewMain { get; set; }
        public FrmMain()
        {
            InitializeComponent();

            InitializeLabelEvents();

            MyScrewMain = new Screw();
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

        private void LoadComboType()
        {
            DataTable DatosDeTipos = new DataTable();

            DatosDeTipos = ScrewTypeLogic.Instancia.ListarCombo();

            cbScrewTypes.ValueMember = "IDScrewType";

            cbScrewTypes.DisplayMember = "TypeName";

            cbScrewTypes.DataSource = DatosDeTipos;

            cbScrewTypes.SelectedIndex = -1;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ResetAppereance();
        }

        private void ResetAppereance()
        {
            LoadComboType();

            lbDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            btnExit.IconChar = IconChar.ArrowRightFromBracket;

            txtAbbreviationName.Text = "---";
            txtMaterialName.Text = "---";
            txtNToolName.Text = "---";

            txtSSNEPartNumber.Text = "";
            txtVendorPartNumber.Text = "";

            txtIDScrew.Clear();

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

            foreach (Control control in pLengths.Controls)
            {
                if (control is Label && control.Name.StartsWith("c"))
                {
                    control.BackColor = Color.White;
                }
            }

            cbScrewTypes.SelectedIndex = -1;

            MyScrewMain = new Screw();

        }

        // Hasta Ahora ya tengo el IDScrewType
      

        private void cbDriveType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbScrewTypes.SelectedIndex >= 0)
            {
                MyScrewMain.MyScrewType.IDScrewType = Convert.ToInt32(cbScrewTypes.SelectedValue);
            }
            else
            {
                MyScrewMain.MyScrewType.IDScrewType = 0;
            }

            // Se permite continuar con el siguiente paso
            pSizeSelect.Enabled = true;

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
            if (MyScrewMain.MyScrewSize.IDScrewSize != 0)
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
            else
            {
                MessageBox.Show("This Size isn't register yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectColumnLength(object sender, EventArgs e)
        {
            if (MyScrewMain.MyScrewLength.IDScrewLength != 0)
            {
                try
                {
                    int IDType = MyScrewMain.MyScrewType.IDScrewType;
                    int IDSize = MyScrewMain.MyScrewSize.IDScrewSize;
                    int IDLength = MyScrewMain.MyScrewLength.IDScrewLength;

                    if (IDType != 0 && IDSize != 0 && IDLength != 0)
                    {
                        MyScrewMain = ScrewLogic.Instancia.SelectScrewByTypeSizeLength(IDType, IDSize, IDLength);

                        txtIDScrew.Text = MyScrewMain.IDScrew.ToString();

                        txtSSNEPartNumber.Text = MyScrewMain.SSNEPartNumber;
                        txtVendorPartNumber.Text = MyScrewMain.VendorPartNumber;
                        
                        txtMaterialName.Text = MyScrewMain.MyScrewMaterial.MaterialName;

                        txtAbbreviationName.Text = MyScrewMain.MyScrewAbbreviation.AbbreviationName;

                        txtNToolName.Text = MyScrewMain.MyScrewNTool.NToolName;

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void btnPDF_Click(object sender, EventArgs e)
        {
            FrmViewPDF frmScale = new FrmViewPDF(MyScrewMain.UrlPDF.ToString());
            frmScale.ShowDialog();
        }

        private void btnSTP_Click(object sender, EventArgs e)
        {
            FrmViewPDF frmScale = new FrmViewPDF(MyScrewMain.UrlSTEP.ToString());
            frmScale.ShowDialog();
        }


        // Abrir Dashboard Management DataBase System
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

        private void s1_Click(object sender, EventArgs e)
        {
            string SizeName = s1.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();   

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void s2_Click(object sender, EventArgs e)
        {
            string SizeName = s2.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s3_Click(object sender, EventArgs e)
        {
            string SizeName = s3.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s4_Click(object sender, EventArgs e)
        {
            string SizeName = s4.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s5_Click(object sender, EventArgs e)
        {
            string SizeName = s5.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s6_Click(object sender, EventArgs e)
        {
            string SizeName = s6.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s7_Click(object sender, EventArgs e)
        {
            string SizeName = s7.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s8_Click(object sender, EventArgs e)
        {
            string SizeName = s8.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s9_Click(object sender, EventArgs e)
        {
            string SizeName = s9.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void s10_Click(object sender, EventArgs e)
        {
            string SizeName = s10.Text.ToString().Replace(" ", "");

            try
            {
                ScrewSize MyScrewSize = new ScrewSize();

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByName(SizeName);

                if (MyScrewSize != null)
                {
                    MyScrewMain.MyScrewSize.IDScrewSize = MyScrewSize.IDScrewSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetAppereance();
        }

        private void c1_Click(object sender, EventArgs e)
        {
            string LengthName = c1.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c1a_Click(object sender, EventArgs e)
        {
            string LengthName = c1a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c1b_Click(object sender, EventArgs e)
        {
            string LengthName = c1b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            string LengthName = c2.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c2a_Click(object sender, EventArgs e)
        {
            string LengthName = c2a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c2b_Click(object sender, EventArgs e)
        {
            string LengthName = c2b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            string LengthName = c3.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c3a_Click(object sender, EventArgs e)
        {
            string LengthName = c3a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c3b_Click(object sender, EventArgs e)
        {
            string LengthName = c3b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c4_Click(object sender, EventArgs e)
        {
            string LengthName = c4.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c4a_Click(object sender, EventArgs e)
        {
            string LengthName = c4a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c4b_Click(object sender, EventArgs e)
        {
            string LengthName = c4b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c5_Click(object sender, EventArgs e)
        {
            string LengthName = c5.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c5a_Click(object sender, EventArgs e)
        {
            string LengthName = c5a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c5b_Click(object sender, EventArgs e)
        {
            string LengthName = c5b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c6_Click(object sender, EventArgs e)
        {
            string LengthName = c6.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c6a_Click(object sender, EventArgs e)
        {
            string LengthName = c6a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c6b_Click(object sender, EventArgs e)
        {
            string LengthName = c6b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c7_Click(object sender, EventArgs e)
        {
            string LengthName = c7.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c7a_Click(object sender, EventArgs e)
        {
            string LengthName = c7a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c7b_Click(object sender, EventArgs e)
        {
            string LengthName = c7b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c8_Click(object sender, EventArgs e)
        {
            string LengthName = c8.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c8a_Click(object sender, EventArgs e)
        {
            string LengthName = c8a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c8b_Click(object sender, EventArgs e)
        {
            string LengthName = c8b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c9_Click(object sender, EventArgs e)
        {
            string LengthName = c9.Text.ToString();

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c9a_Click(object sender, EventArgs e)
        {
            string LengthName = c9a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c9b_Click(object sender, EventArgs e)
        {
            string LengthName = c9b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c10_Click(object sender, EventArgs e)
        {
            string LengthName = c10.Text.ToString();

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c10a_Click(object sender, EventArgs e)
        {
            string LengthName = c10a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c10b_Click(object sender, EventArgs e)
        {
            string LengthName = c10b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c11_Click(object sender, EventArgs e)
        {
            string LengthName = c11.Text.ToString();

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c11a_Click(object sender, EventArgs e)
        {
            string LengthName = c11a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c11b_Click(object sender, EventArgs e)
        {
            string LengthName = c11b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c12_Click(object sender, EventArgs e)
        {
            string LengthName = c12.Text.ToString();

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c12a_Click(object sender, EventArgs e)
        {
            string LengthName = c12a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c12b_Click(object sender, EventArgs e)
        {
            string LengthName = c12b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c13_Click(object sender, EventArgs e)
        {
            string LengthName = c13.Text.ToString();

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c13a_Click(object sender, EventArgs e)
        {
            string LengthName = c13a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c13b_Click(object sender, EventArgs e)
        {
            string LengthName = c13b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c14_Click(object sender, EventArgs e)
        {
            string LengthName = c14.Text.ToString();

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c14a_Click(object sender, EventArgs e)
        {
            string LengthName = c14a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c14b_Click(object sender, EventArgs e)
        {
            string LengthName = c14b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c15_Click(object sender, EventArgs e)
        {
            string LengthName = c15.Text.ToString();

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c15a_Click(object sender, EventArgs e)
        {
            string LengthName = c15a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c15b_Click(object sender, EventArgs e)
        {
            string LengthName = c15b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c16_Click(object sender, EventArgs e)
        {
            string LengthName = c9.Text.ToString();

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c16a_Click(object sender, EventArgs e)
        {
            string LengthName = c16a.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c16b_Click(object sender, EventArgs e)
        {
            string LengthName = c16b.Text.ToString().Replace(" ", "");

            try
            {
                ScrewLength MyScrewLength = new ScrewLength();

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByName(LengthName);

                if (MyScrewLength != null)
                {
                    MyScrewMain.MyScrewLength.IDScrewLength = MyScrewLength.IDScrewLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
