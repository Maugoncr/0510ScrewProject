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

namespace _0510Project.Forms.SelectedForms
{
    public partial class FrmSelectScrewNTool : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewNTool MyScrewNTool { get; set; }

        public FrmSelectScrewNTool()
        {
            InitializeComponent();

            MyScrewNTool = new ScrewNTool();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvScrewNTools.SelectedRows.Count > 0)
            {
                try
                {
                    FrmScrew.IDScrewNTool = Convert.ToInt32(dgvScrewNTools.SelectedRows[0].Cells["CIDScrewNTool"].Value);
                    FrmScrew.NToolName = Convert.ToString(dgvScrewNTools.SelectedRows[0].Cells["CNToolName"].Value);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any number tool of screw.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewNTool(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewNTool(true);
            }
        }

        private void dgvScrewNTools_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewNTools.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewNTools.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrewNTool"].Value);

                MyScrewNTool = ScrewNToolLogic.Instancia.SelectByID(ID);

                txtIDScrewNTool.Text = MyScrewNTool.IDScrewNTool.ToString();
                txtNToolName.Text = MyScrewNTool.NToolName;

                Activar();
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmSelectScrewNTool_Load(object sender, EventArgs e)
        {
            ShowScrewNTool(true);

            CleanForm();
        }

        public void Activar()
        {
            btnSelect.Enabled = true;
        }

        private void Desactivar()
        {
            btnSelect.Enabled = false;
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrewNTool.Clear();
            txtNToolName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyScrewNTool = new ScrewNTool();
            Desactivar();
        }

        private void ShowScrewNTool(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewNTools.DataSource = ScrewNToolLogic.Instancia.Listar(true, Filtro);

            dgvScrewNTools.ClearSelection();
        }

    }
}
