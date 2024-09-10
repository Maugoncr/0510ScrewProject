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
    public partial class FrmSelectScrewMaterial : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewMaterial MyScrewMaterial { get; set; }

        public FrmSelectScrewMaterial()
        {
            InitializeComponent();

            MyScrewMaterial = new ScrewMaterial();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSelectScrewMaterial_Load(object sender, EventArgs e)
        {
            ShowScrewMaterial(true);

            CleanForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewMaterial(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewMaterial(true);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvScrewMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewMaterials.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewMaterials.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrewMaterial"].Value);

                MyScrewMaterial = ScrewMaterialLogic.Instancia.SelectByID(ID);

                txtIDScrewMaterial.Text = MyScrewMaterial.IDScrewMaterial.ToString();
                txtMaterialName.Text = MyScrewMaterial.MaterialName;

                Activar();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvScrewMaterials.SelectedRows.Count > 0)
            {
                try
                {
                    FrmScrew.IDScrewMaterial = Convert.ToInt32(dgvScrewMaterials.SelectedRows[0].Cells["CIDScrewMaterial"].Value);
                    FrmScrew.MaterialName = Convert.ToString(dgvScrewMaterials.SelectedRows[0].Cells["CMaterialName"].Value);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any material of screw.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            txtIDScrewMaterial.Clear();
            txtMaterialName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyScrewMaterial = new ScrewMaterial();
            Desactivar();
        }

        private void ShowScrewMaterial(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewMaterials.DataSource = ScrewMaterialLogic.Instancia.Listar(true, Filtro);

            dgvScrewMaterials.ClearSelection();
        }


    }
}
