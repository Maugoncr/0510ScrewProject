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
    public partial class FrmSelectScrewAbbreviation : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewAbbreviation MyScrewAbbreviation { get; set; }

        public FrmSelectScrewAbbreviation()
        {
            InitializeComponent();

            MyScrewAbbreviation = new ScrewAbbreviation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvScrewAbbreviations.SelectedRows.Count > 0)
            {
                try
                {
                    FrmScrew.IDScrewAbbreviation = Convert.ToInt32(dgvScrewAbbreviations.SelectedRows[0].Cells["CIDScrewAbbreviation"].Value);
                    FrmScrew.AbbreviationName = Convert.ToString(dgvScrewAbbreviations.SelectedRows[0].Cells["CAbbreviationName"].Value);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any abbreviation of screw.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewAbbreviation(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewAbbreviation(true);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvScrewAbbreviations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewAbbreviations.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewAbbreviations.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrewAbbreviation"].Value);

                MyScrewAbbreviation = ScrewAbbreviationLogic.Instancia.SelectByID(ID);

                txtIDScrewAbbreviation.Text = MyScrewAbbreviation.IDScrewAbbreviation.ToString();
                txtAbbreviationName.Text = MyScrewAbbreviation.AbbreviationName;

                Activar();
            }
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
            txtIDScrewAbbreviation.Clear();
            txtAbbreviationName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyScrewAbbreviation = new ScrewAbbreviation();
            Desactivar();
        }

        private void ShowScrewAbbreviation(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";

            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewAbbreviations.DataSource = ScrewAbbreviationLogic.Instancia.Listar(true, Filtro);

            dgvScrewAbbreviations.ClearSelection();
        }

        private void FrmSelectScrewAbbreviation_Load(object sender, EventArgs e)
        {
            ShowScrewAbbreviation(true);

            CleanForm();
        }
    }
}
