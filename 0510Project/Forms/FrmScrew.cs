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
    public partial class FrmScrew : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Screw MyScrew { get; set; }

        public FrmScrew()
        {
            InitializeComponent();

            MyScrew = new Screw();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void LoadAvailableTools()
        {
        }

        private void FrmScrew_Load(object sender, EventArgs e)
        {
            //LoadAvailableTools();

            ShowScrews(checkActives.Checked);

            CleanForm();
        }

        private void ShowScrews(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrews.DataSource = ScrewLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvScrews.ClearSelection();
        }

        private void dgvScrews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrews.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrews.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrew"].Value);

                MyScrew = ScrewLogic.Instancia.SelectScrewByID(ID);

                txtIDScrew.Text = MyScrew.IDScrew.ToString();
                txtSSNEPartNumber.Text = MyScrew.SSNEPartNumber;

                txtVendorPartNumber.Text = MyScrew.VendorPartNumber;
                txtUrlPDF.Text = MyScrew.UrlPDF;
                txtUrlSTEP.Text = MyScrew.UrlSTEP;

                txtIDScrewType.Text = MyScrew.MyScrewType.IDScrewType.ToString();
                txtTypeName.Text = MyScrew.MyScrewType.TypeName;

                txtIDScrewMaterial.Text = MyScrew.MyScrewMaterial.IDScrewMaterial.ToString();
                txtMaterialName.Text = MyScrew.MyScrewMaterial.MaterialName;

                txtIDScrewAbbreviation.Text = MyScrew.MyScrewAbbreviation.IDScrewAbbreviation.ToString();
                txtAbbreviationName.Text = MyScrew.MyScrewAbbreviation.AbbreviationName;

                txtIDScrewSize.Text = MyScrew.MyScrewSize.IDScrewSize.ToString();
                txtSizeName.Text = MyScrew.MyScrewSize.SizeName;

                txtIDScrewLength.Text = MyScrew.MyScrewLength.IDScrewLength.ToString();
                txtLengthInch.Text = MyScrew.MyScrewLength.LengthInch;

                txtIDScrewNTool.Text = MyScrew.MyScrewNTool.IDScrewNTool.ToString();
                txtNToolName.Text = MyScrew.MyScrewNTool.NToolName;

                dgvAvailableTools.DataSource = ScrewLogic.Instancia.SelectScrewAvailableToolsByID(ID);
                dgvAvailableTools.ClearSelection();

                EnableUpdate_Disable();
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowScrews(checkActives.Checked);

            if (checkActives.Checked)
            {
                btnDisable.Text = "     Disable";

                btnDisable.IconChar = FontAwesome.Sharp.IconChar.Ban;
            }
            else
            {

                btnDisable.Text = "     Enable";

                btnDisable.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            }
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrew.Clear();
            txtSSNEPartNumber.Clear();
            txtVendorPartNumber.Clear();
            txtUrlPDF.Clear();
            txtUrlSTEP.Clear();

            txtIDScrewType.Clear();
            txtTypeName.Clear();

            txtIDScrewMaterial.Clear();
            txtMaterialName.Clear();

            txtIDScrewAbbreviation.Clear();
            txtAbbreviationName.Clear();

            txtIDScrewSize.Clear();
            txtSizeName.Clear();

            txtIDScrewLength.Clear();
            txtLengthInch.Clear();

            txtIDScrewNTool.Clear();
            txtNToolName.Clear();


            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }
            MyScrew = new Screw();

            if (dgvAvailableTools.DataSource != null)
            {
                ((DataTable)dgvAvailableTools.DataSource).Rows.Clear();
            }

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

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrews(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrews(checkActives.Checked);
            }
        }

        public static int IDScrewType;
        public static string TypeName;

        private void btnSelectScrewType_Click(object sender, EventArgs e)
        {
            FrmSelectScrewType frm = new FrmSelectScrewType();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDScrewType.Text = IDScrewType.ToString();
                txtTypeName.Text = TypeName;
            }
        }

        private void txtIDScrewType_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDScrewType.Text.Trim()))
            {
                MyScrew.MyScrewType.IDScrewType = Convert.ToInt32(txtIDScrewType.Text.Trim());
            }
            else
            {
                MyScrew.MyScrewType.IDScrewType = 0;
            }
        }

        private void btnClearScrewType_Click(object sender, EventArgs e)
        {
            txtIDScrewType.Clear();
            txtTypeName.Clear();
        }

        private void btnCheckUrlPDF_Click(object sender, EventArgs e)
        {
            FrmViewPDF frmScale = new FrmViewPDF("https://drive.google.com/file/d/14ZVIqs6Lp-E-Qg7wtM1tgMs1xVekFcEn/view?usp=drive_link");
            frmScale.ShowDialog();
        }

        public static int IDScrewSize;
        public static string SizeName;
        private void btnSelectScrewSize_Click(object sender, EventArgs e)
        {
            FrmSelectScrewSize frm = new FrmSelectScrewSize();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDScrewSize.Text = IDScrewSize.ToString();
                txtSizeName.Text = SizeName;
            }
        }

        private void txtIDScrewSize_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDScrewSize.Text.Trim()))
            {
                MyScrew.MyScrewSize.IDScrewSize = Convert.ToInt32(txtIDScrewSize.Text.Trim());
            }
            else
            {
                MyScrew.MyScrewSize.IDScrewSize = 0;
            }
        }

        private void btnClearScrewSize_Click(object sender, EventArgs e)
        {
            txtIDScrewSize.Clear();
            txtSizeName.Clear();
        }

        public static int IDScrewMaterial;
        public static string MaterialName;

        private void btnSelectScrewMaterial_Click(object sender, EventArgs e)
        {
            FrmSelectScrewMaterial frm = new FrmSelectScrewMaterial();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDScrewMaterial.Text = IDScrewMaterial.ToString();
                txtMaterialName.Text = MaterialName;
            }
        }

        private void txtIDScrewMaterial_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDScrewMaterial.Text.Trim()))
            {
                MyScrew.MyScrewMaterial.IDScrewMaterial = Convert.ToInt32(txtIDScrewMaterial.Text.Trim());
            }
            else
            {
                MyScrew.MyScrewMaterial.IDScrewMaterial = 0;
            }
        }

        private void btnClearScrewMaterial_Click(object sender, EventArgs e)
        {
            txtIDScrewMaterial.Clear();
            txtMaterialName.Clear();
        }

        public static int IDScrewLength;
        public static string LengthInch;

        private void btnSelectScrewLength_Click(object sender, EventArgs e)
        {
            FrmSelectScrewLength frm = new FrmSelectScrewLength();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDScrewLength.Text = IDScrewLength.ToString();
                txtLengthInch.Text = LengthInch;
            }
        }

        private void txtIDScrewLength_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDScrewLength.Text.Trim()))
            {
                MyScrew.MyScrewLength.IDScrewLength = Convert.ToInt32(txtIDScrewLength.Text.Trim());
            }
            else
            {
                MyScrew.MyScrewLength.IDScrewLength = 0;
            }
        }

        private void btnClearScrewLength_Click(object sender, EventArgs e)
        {
            txtIDScrewLength.Clear();
            txtLengthInch.Clear();
        }

        public static int IDScrewAbbreviation;
        public static string AbbreviationName;

        private void btnSelectScrewAbbreviation_Click(object sender, EventArgs e)
        {
            FrmSelectScrewAbbreviation frm = new FrmSelectScrewAbbreviation();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDScrewAbbreviation.Text = IDScrewAbbreviation.ToString();
                txtAbbreviationName.Text = AbbreviationName;
            }
        }

        private void txtIDScrewAbbreviation_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDScrewAbbreviation.Text.Trim()))
            {
                MyScrew.MyScrewAbbreviation.IDScrewAbbreviation = Convert.ToInt32(txtIDScrewAbbreviation.Text.Trim());
            }
            else
            {
                MyScrew.MyScrewAbbreviation.IDScrewAbbreviation = 0;
            }
        }

        private void btnClearScrewAbbreviation_Click(object sender, EventArgs e)
        {
            txtIDScrewAbbreviation.Clear();
            txtAbbreviationName.Clear();
        }

        public static int IDScrewNTool;
        public static string NToolName;

        private void btnSelectScrewNTool_Click(object sender, EventArgs e)
        {
            FrmSelectScrewNTool frm = new FrmSelectScrewNTool();

            DialogResult r = frm.ShowDialog();

            if (r == DialogResult.OK)
            {
                txtIDScrewNTool.Text = IDScrewNTool.ToString();
                txtNToolName.Text = NToolName;
            }
        }

        private void btnClearScrewNTool_Click(object sender, EventArgs e)
        {
            txtIDScrewNTool.Clear();
            txtNToolName.Clear();
        }

        private void txtIDScrewNTool_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDScrewNTool.Text.Trim()))
            {
                MyScrew.MyScrewNTool.IDScrewNTool = Convert.ToInt32(txtIDScrewNTool.Text.Trim());
            }
            else
            {
                MyScrew.MyScrewNTool.IDScrewNTool = 0;
            }
        }

        private void txtSSNEPartNumber_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSSNEPartNumber.Text.Trim()))
            {
                MyScrew.SSNEPartNumber = txtSSNEPartNumber.Text.Trim();
            }
            else
            {
                MyScrew.SSNEPartNumber = "";
            }
        }

        private void txtVendorPartNumber_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVendorPartNumber.Text.Trim()))
            {
                MyScrew.VendorPartNumber = txtVendorPartNumber.Text.Trim();
            }
            else
            {
                MyScrew.VendorPartNumber = "";
            }
        }

        private void txtUrlPDF_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlPDF.Text.Trim()))
            {
                MyScrew.UrlPDF = txtUrlPDF.Text.Trim();
            }
            else
            {
                MyScrew.UrlPDF = "";
            }
        }

        private void txtUrlSTEP_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlSTEP.Text.Trim()))
            {
                MyScrew.UrlSTEP = txtUrlSTEP.Text.Trim();
            }
            else
            {
                MyScrew.UrlSTEP = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateDataToAdd())
            {
                bool R = ScrewLogic.Instancia.Guardar(MyScrew);

                if (R)
                {
                    CleanForm();
                    ShowScrews(checkActives.Checked);
                    MessageBox.Show("Screw Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidateDataToAdd()
        {
            bool R = false;

            if (
                MyScrew.MyScrewType.IDScrewType > 0 &&
                MyScrew.MyScrewSize.IDScrewSize > 0 &&
                MyScrew.MyScrewLength.IDScrewLength > 0 &&
                MyScrew.MyScrewMaterial.IDScrewMaterial > 0 &&
                MyScrew.MyScrewAbbreviation.IDScrewAbbreviation > 0 &&
                MyScrew.MyScrewNTool.IDScrewNTool > 0 &&
                !string.IsNullOrEmpty(MyScrew.SSNEPartNumber) &&
                !string.IsNullOrEmpty(MyScrew.VendorPartNumber) &&
                !string.IsNullOrEmpty(MyScrew.UrlPDF) &&
                !string.IsNullOrEmpty(MyScrew.UrlSTEP)
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

        private void btnSearchAvailableTool_Click(object sender, EventArgs e)
        {
            using (var modal = new FrmSelectAvailableTool())
            {
                var result = modal.ShowDialog();


                if (result == DialogResult.OK)
                {
                    txtIDAvailableTool.Text = modal._MyScrewAvailableTool.IDScrewTool.ToString();
                    txtAvailableToolName.Text = modal._MyScrewAvailableTool.ToolName;
                }
            }
        }

        private void btnAddAvailableTool_Click(object sender, EventArgs e)
        {
            bool toolExist = false;

            if (string.IsNullOrEmpty(txtIDAvailableTool.Text))
            {
                MessageBox.Show("You haven't selected any tool to add.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dgvAvailableTools.Rows)
            {
                if (row.Cells["CIDScrewTool"].Value.ToString() == txtIDAvailableTool.Text)
                {
                    toolExist = true;
                    break;
                }
            }

            if (!toolExist)
            {
                dgvAvailableTools.Rows.Add(new object[] {
                    txtIDAvailableTool.Text,
                    txtAvailableToolName.Text,
                });

                txtAvailableToolName.Clear();
                txtIDAvailableTool.Clear();

                dgvAvailableTools.ClearSelection();
            }
            else
            {
                MessageBox.Show("You cannot add the same tool again.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void dgvAvailableTools_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
    }
}
