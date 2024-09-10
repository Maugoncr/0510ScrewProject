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
    public partial class FrmSelectScrewSize : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewSize MyScrewSize { get; set; }

        public FrmSelectScrewSize()
        {
            InitializeComponent();

            MyScrewSize = new ScrewSize();
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSelectScrewSize_Load(object sender, EventArgs e)
        {
            ShowScrewSizes(true);

            CleanForm();
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrewSize.Clear();
            txtSizeName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyScrewSize = new ScrewSize();
            Desactivar();
        }

        private void ShowScrewSizes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewSizes.DataSource = ScrewSizeLogic.Instancia.Listar(true, Filtro);

            dgvScrewSizes.ClearSelection();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Activar()
        {
            btnSelect.Enabled = true;
        }

        private void Desactivar()
        {
            btnSelect.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvScrewSizes.SelectedRows.Count > 0)
            {
                try
                {
                    FrmScrew.IDScrewSize = Convert.ToInt32(dgvScrewSizes.SelectedRows[0].Cells["CIDScrewSize"].Value);
                    FrmScrew.SizeName = Convert.ToString(dgvScrewSizes.SelectedRows[0].Cells["CSizeName"].Value);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any size of screw.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvScrewSizes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewSizes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewSizes.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrewSize"].Value);

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByID(ID);

                txtIDScrewSize.Text = MyScrewSize.IDScrewSize.ToString();
                txtSizeName.Text = MyScrewSize.SizeName;

                Activar();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewSizes(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewSizes(true);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }
    }
}
