using _0510Project.Forms.SelectedForms;
using Logica.Logic;
using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace _0510Project.Forms
{
    public partial class FrmNuts : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Nuts MyNuts { get; set; }

        public FrmNuts()
        {
            InitializeComponent();
            MyNuts = new Nuts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowNuts(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowNuts(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowNuts(checkActives.Checked);

            if (checkActives.Checked)
            {
                btnDisable.Text = "Disable";
            }
            else
            {
                btnDisable.Text = "Enable";
            }
        }

        private void dgvNuts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNuts.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvNuts.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDNuts"].Value);

                MyNuts = NutsLogic.Instancia.SelectScrewByID(ID);

                txtIDNuts.Text = MyNuts.IDNuts.ToString();
                txtSSNEPartNumber.Text = MyNuts.SSNEPartNumber;
                txtVendorPartNumber.Text = MyNuts.VendorPartNumber;
                txtUrlPDF.Text = MyNuts.UrlPDF;
                txtUrlSTEP.Text = MyNuts.UrlSTEP;

                txtIDNutsType.Text = MyNuts.MyNutType.IDNutsType.ToString();
                txtTypeName.Text = MyNuts.MyNutType.NutsTypeName;

                txtIDNutsSize.Text = MyNuts.MyNutSize.IDNutsSize.ToString();
                txtSizeName.Text = MyNuts.MyNutSize.NutsSizeName;

                EnableUpdate_Disable();
            }
        }

        public static int IDNutsType;
        public static string TypeName;
        private void btnSelectNutType_Click(object sender, EventArgs e)
        {
            FrmSelectNutType frm = new FrmSelectNutType();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDNutsType.Text = IDNutsType.ToString();
                txtTypeName.Text = TypeName;
            }
        }

        private void btnClearNutType_Click(object sender, EventArgs e)
        {
            txtIDNutsType.Clear();
            txtTypeName.Clear();
        }

        public static int IDNutsSize;
        public static string SizeName;
        private void btnSelectNutsSize_Click(object sender, EventArgs e)
        {
            FrmSelectNutSize frm = new FrmSelectNutSize();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDNutsSize.Text = IDNutsSize.ToString();
                txtSizeName.Text = SizeName;
            }
        }

        private void btnClearNutsSize_Click(object sender, EventArgs e)
        {
            txtIDNutsSize.Clear();
            txtSizeName.Clear();
        }

        private void txtIDNutsType_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDNutsType.Text.Trim()))
            {
                MyNuts.MyNutType.IDNutsType = Convert.ToInt32(txtIDNutsType.Text.Trim());
            }
            else
            {
                MyNuts.MyNutType.IDNutsType = 0;
            }
        }

        private void txtIDNutsSize_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDNutsSize.Text.Trim()))
            {
                MyNuts.MyNutSize.IDNutsSize = Convert.ToInt32(txtIDNutsSize.Text.Trim());
            }
            else
            {
                MyNuts.MyNutSize.IDNutsSize = 0;
            }
        }

        private void txtSSNEPartNumber_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSSNEPartNumber.Text.Trim()))
            {
                MyNuts.SSNEPartNumber = txtSSNEPartNumber.Text.Trim();
            }
            else
            {
                MyNuts.SSNEPartNumber = "";
            }
        }

        private void txtVendorPartNumber_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVendorPartNumber.Text.Trim()))
            {
                MyNuts.VendorPartNumber = txtVendorPartNumber.Text.Trim();
            }
            else
            {
                MyNuts.VendorPartNumber = "";
            }
        }

        private void txtUrlPDF_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlPDF.Text.Trim()))
            {
                MyNuts.UrlPDF = txtUrlPDF.Text.Trim();
            }
            else
            {
                MyNuts.UrlPDF = "";
            }
        }

        private void txtUrlSTEP_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlSTEP.Text.Trim()))
            {
                MyNuts.UrlSTEP = txtUrlSTEP.Text.Trim();
            }
            else
            {
                MyNuts.UrlSTEP = "";
            }
        }

        private void btnCheckUrlPDF_Click(object sender, EventArgs e)
        {
            FrmViewPDF frmScale = new FrmViewPDF(txtUrlPDF.Text.ToString());
            frmScale.ShowDialog();
        }

        private void btnCheckUrlSTEP_Click(object sender, EventArgs e)
        {
            FrmViewPDF frmScale = new FrmViewPDF(txtUrlSTEP.Text.ToString());
            frmScale.ShowDialog();
        }
        private bool ValidateDataToAdd()
        {
            bool R = false;

            if (
                MyNuts.MyNutType.IDNutsType > 0 &&
                MyNuts.MyNutSize.IDNutsSize > 0 &&
                !string.IsNullOrEmpty(MyNuts.SSNEPartNumber) &&
                !string.IsNullOrEmpty(MyNuts.VendorPartNumber) &&
                !string.IsNullOrEmpty(MyNuts.UrlPDF) &&
                !string.IsNullOrEmpty(MyNuts.UrlSTEP)
                )
            {
                R = true;
                return R;
            }
            else
            {
                MessageBox.Show("You cannot enter a record with missing data.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return R;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateDataToAdd())
            {
                bool R = false;

                R = NutsLogic.Instancia.Guardar(MyNuts);

                if (R)
                {
                    CleanForm();
                    ShowNuts(checkActives.Checked);
                    MessageBox.Show("Nut Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateDataToAdd())
            {
                bool respuesta = NutsLogic.Instancia.Editar(MyNuts);

                if (respuesta)
                {
                    CleanForm();
                    ShowNuts(checkActives.Checked);
                    MessageBox.Show("Nut Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            Nuts TempObj = NutsLogic.Instancia.SelectScrewByID(Convert.ToInt32(txtIDNuts.Text));

            if (TempObj.IDNuts > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Nut: {0}?", txtIDNuts.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyNuts = new Nuts
                        {
                            IDNuts = Convert.ToInt32(txtIDNuts.Text),
                            Active = 0
                        };

                        if (NutsLogic.Instancia.Disable_Enable(MyNuts))
                        {
                            MessageBox.Show("Nut successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowNuts(checkActives.Checked);
                        }
                    }
                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Nut: {0}?", txtIDNuts.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyNuts = new Nuts
                        {
                            IDNuts = Convert.ToInt32(txtIDNuts.Text),
                            Active = 1
                        };

                        if (NutsLogic.Instancia.Disable_Enable(MyNuts))
                        {
                            MessageBox.Show("Nut successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowNuts(checkActives.Checked);
                        }
                    }
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void FrmNuts_Load(object sender, EventArgs e)
        {
            ShowNuts(checkActives.Checked);
            CleanForm();
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ShowNuts(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvNuts.DataSource = NutsLogic.Instancia.Listar(SeeActives, Filtro);

            dgvNuts.ClearSelection();
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDNuts.Clear();
            txtSSNEPartNumber.Clear();
            txtVendorPartNumber.Clear();
            txtUrlPDF.Clear();
            txtUrlSTEP.Clear();

            txtIDNutsType.Clear();
            txtTypeName.Clear();

            txtIDNutsSize.Clear();
            txtSizeName.Clear();


            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyNuts = new Nuts();

            EnableSave();
        }

        private void EnableSave()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDisable.Enabled = false;
        }

        private void EnableUpdate_Disable()
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDisable.Enabled = true;
        }
    }
}
