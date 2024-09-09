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
    public partial class FrmSelectScrewType : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewType MyScrewType { get; set; }

        public FrmSelectScrewType()
        {
            InitializeComponent();

            MyScrewType = new ScrewType();
        }

        private void FrmSelectScrewType_Load(object sender, EventArgs e)
        {
            ShowScrewTypes(true);

            CleanForm();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrewType.Clear();
            txtTypeName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyScrewType = new ScrewType();
            Desactivar();
        }

        private void ShowScrewTypes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewTypes.DataSource = ScrewTypeLogic.Instancia.Listar(true, Filtro);

            dgvScrewTypes.ClearSelection();
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewTypes(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewTypes(true);
            }
        }

        private void dgvScrewTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewTypes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewTypes.SelectedRows[0];

                int IDScrewType = Convert.ToInt32(MyRow.Cells["CIDScrewType"].Value);

                MyScrewType = ScrewTypeLogic.Instancia.SelectByID(IDScrewType);

                txtIDScrewType.Text = MyScrewType.IDScrewType.ToString();
                txtTypeName.Text = MyScrewType.TypeName;

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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvScrewTypes.SelectedRows.Count > 0)
            {
                try
                {
                    FrmScrew.IDScrewType = Convert.ToInt32(dgvScrewTypes.SelectedRows[0].Cells["CIDScrewType"].Value);
                    FrmScrew.TypeName = Convert.ToString(dgvScrewTypes.SelectedRows[0].Cells["CTypeName"].Value);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any type of screw.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
