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
    public partial class FrmSelectScrewLength : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewLength MyScrewLength { get; set; }


        public FrmSelectScrewLength()
        {
            InitializeComponent();

            MyScrewLength = new ScrewLength();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSelectScrewLength_Load(object sender, EventArgs e)
        {
            ShowScrewLength(true);

            CleanForm();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvScrewLengths.SelectedRows.Count > 0)
            {
                try
                {
                    FrmScrew.IDScrewLength = Convert.ToInt32(dgvScrewLengths.SelectedRows[0].Cells["CIDScrewLength"].Value);
                    FrmScrew.LengthInch = Convert.ToString(dgvScrewLengths.SelectedRows[0].Cells["CLengthInch"].Value);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any length of screw.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewLength(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewLength(true);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvScrewLengths_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewLengths.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewLengths.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrewLength"].Value);

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByID(ID);

                txtIDScrewLength.Text = MyScrewLength.IDScrewLength.ToString();
                txtLengthInch.Text = MyScrewLength.LengthInch;

                Activar();
            }
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            txtIDScrewLength.Clear();
            txtLengthInch.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyScrewLength = new ScrewLength();
            Desactivar();
        }

        private void ShowScrewLength(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewLengths.DataSource = ScrewLengthLogic.Instancia.Listar(true, Filtro);

            dgvScrewLengths.ClearSelection();
        }
    }
}
