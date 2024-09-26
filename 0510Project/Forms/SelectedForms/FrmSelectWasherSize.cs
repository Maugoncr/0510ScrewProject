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
    public partial class FrmSelectWasherSize : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private WasherSize MyWasherSize { get; set; }

        public FrmSelectWasherSize()
        {
            InitializeComponent();

            MyWasherSize = new WasherSize();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowWasherSizes(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowWasherSizes(true);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvWasherSizes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWasherSizes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvWasherSizes.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDWasherSize"].Value);

                MyWasherSize = WasherSizeLogic.Instancia.SelectByID(ID);

                txtIDWasherSize.Text = MyWasherSize.IDWasherSize.ToString();
                txtSizeName.Text = MyWasherSize.WasherSizeName;

                Activar();
            }
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvWasherSizes.SelectedRows.Count > 0)
            {
                try
                {
                    FrmWashers.IDWasherSize = Convert.ToInt32(dgvWasherSizes.SelectedRows[0].Cells["CIDWasherSize"].Value);
                    FrmWashers.SizeName = Convert.ToString(dgvWasherSizes.SelectedRows[0].Cells["CWasherSizeName"].Value);
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

        private void FrmSelectWasherSize_Load(object sender, EventArgs e)
        {
            ShowWasherSizes(true);
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
            txtIDWasherSize.Clear();
            txtSizeName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyWasherSize = new WasherSize();
            Desactivar();
        }

        private void ShowWasherSizes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvWasherSizes.DataSource = WasherSizeLogic.Instancia.Listar(true, Filtro);

            dgvWasherSizes.ClearSelection();
        }

    }
}
