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
    public partial class FrmSelectNutSize : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private NutsSize MyNutSize { get; set; }

        public FrmSelectNutSize()
        {
            InitializeComponent();

            MyNutSize = new NutsSize();
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

        private void FrmSelectNutType_Load(object sender, EventArgs e)
        {
            ShowNutSizes(true);
            CleanForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowNutSizes(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowNutSizes(true);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvNutSizes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNutSizes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvNutSizes.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDNutsSize"].Value);

                MyNutSize = NutsSizeLogic.Instancia.SelectByID(ID);

                txtIDNutSize.Text = MyNutSize.IDNutsSize.ToString();
                txtSizeName.Text = MyNutSize.NutsSizeName;

                Activar();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvNutSizes.SelectedRows.Count > 0)
            {
                try
                {
                    FrmNuts.IDNutsSize = Convert.ToInt32(dgvNutSizes.SelectedRows[0].Cells["CIDNutsSize"].Value);
                    FrmNuts.SizeName = Convert.ToString(dgvNutSizes.SelectedRows[0].Cells["CNutsSizeName"].Value);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any size of washer.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDNutSize.Clear();
            txtSizeName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyNutSize = new NutsSize();
            Desactivar();
        }

        private void ShowNutSizes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvNutSizes.DataSource = NutsSizeLogic.Instancia.Listar(true, Filtro);

            dgvNutSizes.ClearSelection();
        }

    }
}
