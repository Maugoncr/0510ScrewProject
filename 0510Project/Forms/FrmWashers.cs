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

namespace _0510Project.Forms
{
    public partial class FrmWashers : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Washers MyWashers { get; set; }

        public FrmWashers()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWashers_Load(object sender, EventArgs e)
        {
            ShowWashers(checkActives.Checked);
            CleanForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowWashers(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowWashers(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowWashers(checkActives.Checked);

            if (checkActives.Checked)
            {
                btnDisable.Text = "Disable";
            }
            else
            {
                btnDisable.Text = "Enable";
            }
        }

        private void dgvWashers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWashers.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvWashers.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDWasher"].Value);

                MyWashers = WashersLogic.Instancia.SelectScrewByID(ID);

                txtIDWasher.Text = MyWashers.IDWasher.ToString();
                txtSSNEPartNumber.Text = MyWashers.SSNEPartNumber;
                txtVendorPartNumber.Text = MyWashers.VendorPartNumber;
                txtUrlPDF.Text = MyWashers.UrlPDF;
                txtUrlSTEP.Text = MyWashers.UrlSTEP;

                txtIDWasherType.Text = MyWashers.MyWasherType.IDWasherType.ToString();
                txtTypeName.Text = MyWashers.MyWasherType.WasherTypeName;

                txtIDWasherSize.Text = MyWashers.MyWasherSize.IDWasherSize.ToString();
                txtSizeName.Text = MyWashers.MyWasherSize.WasherSizeName;

                EnableUpdate_Disable();
            }
        }

        private void txtIDWasherType_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDWasherType.Text.Trim()))
            {
                MyWashers.MyWasherType.IDWasherType = Convert.ToInt32(txtIDWasherType.Text.Trim());
            }
            else
            {
                MyWashers.MyWasherType.IDWasherType = 0;
            }
        }

        private void txtIDWasherSize_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDWasherSize.Text.Trim()))
            {
                MyWashers.MyWasherSize.IDWasherSize = Convert.ToInt32(txtIDWasherSize.Text.Trim());
            }
            else
            {
                MyWashers.MyWasherSize.IDWasherSize = 0;
            }
        }

        public static int IDWasherType;
        public static string TypeName;
        private void btnSelectWasherType_Click(object sender, EventArgs e)
        {
            FrmSelectWasherType frm = new FrmSelectWasherType();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDWasherType.Text = IDWasherType.ToString();
                txtTypeName.Text = TypeName;
            }
        }

        private void btnClearWasherType_Click(object sender, EventArgs e)
        {
            txtIDWasherType.Clear();
            txtTypeName.Clear();
        }

        public static int IDWasherSize;
        public static string SizeName;
        private void btnSelectWasherSize_Click(object sender, EventArgs e)
        {
            FrmSelectWasherSize frm = new FrmSelectWasherSize();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDWasherSize.Text = IDWasherSize.ToString();
                txtSizeName.Text = SizeName;
            }
        }

        private void btnClearWasherSize_Click(object sender, EventArgs e)
        {
            txtIDWasherSize.Clear();
            txtSizeName.Clear();
        }

        private void txtSSNEPartNumber_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSSNEPartNumber.Text.Trim()))
            {
                MyWashers.SSNEPartNumber = txtSSNEPartNumber.Text.Trim();
            }
            else
            {
                MyWashers.SSNEPartNumber = "";
            }
        }

        private void txtVendorPartNumber_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVendorPartNumber.Text.Trim()))
            {
                MyWashers.VendorPartNumber = txtVendorPartNumber.Text.Trim();
            }
            else
            {
                MyWashers.VendorPartNumber = "";
            }
        }

        private void txtUrlPDF_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlPDF.Text.Trim()))
            {
                MyWashers.UrlPDF = txtUrlPDF.Text.Trim();
            }
            else
            {
                MyWashers.UrlPDF = "";
            }
        }

        private void txtUrlSTEP_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlSTEP.Text.Trim()))
            {
                MyWashers.UrlSTEP = txtUrlSTEP.Text.Trim();
            }
            else
            {
                MyWashers.UrlSTEP = "";
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
                MyWashers.MyWasherType.IDWasherType > 0 &&
                MyWashers.MyWasherSize.IDWasherSize > 0 &&
                !string.IsNullOrEmpty(MyWashers.SSNEPartNumber) &&
                !string.IsNullOrEmpty(MyWashers.VendorPartNumber) &&
                !string.IsNullOrEmpty(MyWashers.UrlPDF) &&
                !string.IsNullOrEmpty(MyWashers.UrlSTEP)
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

                R = WashersLogic.Instancia.Guardar(MyWashers);

                if (R)
                {
                    CleanForm();
                    ShowWashers(checkActives.Checked);
                    MessageBox.Show("Washer Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateDataToAdd())
            {
                bool respuesta = WashersLogic.Instancia.Editar(MyWashers);

                if (respuesta)
                {
                    CleanForm();
                    ShowWashers(checkActives.Checked);
                    MessageBox.Show("Washer Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            Washers TempObj = WashersLogic.Instancia.SelectScrewByID(Convert.ToInt32(txtIDWasher.Text));

            if (TempObj.IDWasher > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Washer: {0}?", txtIDWasher.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyWashers = new Washers
                        {
                            IDWasher = Convert.ToInt32(txtIDWasher.Text),
                            Active = 0
                        };

                        if (WashersLogic.Instancia.Disable_Enable(MyWashers))
                        {
                            MessageBox.Show("Washer successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowWashers(checkActives.Checked);
                        }
                    }
                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Washer: {0}?", txtIDWasher.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyWashers = new Washers
                        {
                            IDWasher = Convert.ToInt32(txtIDWasher.Text),
                            Active = 1
                        };

                        if (WashersLogic.Instancia.Disable_Enable(MyWashers))
                        {
                            MessageBox.Show("Washer successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowWashers(checkActives.Checked);
                        }
                    }
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void ShowWashers(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvWashers.DataSource = WashersLogic.Instancia.Listar(SeeActives, Filtro);

            dgvWashers.ClearSelection();
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDWasher.Clear();
            txtSSNEPartNumber.Clear();
            txtVendorPartNumber.Clear();
            txtUrlPDF.Clear();
            txtUrlSTEP.Clear();

            txtIDWasherType.Clear();
            txtTypeName.Clear();

            txtIDWasherSize.Clear();
            txtSizeName.Clear();


            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyWashers = new Washers();

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

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
