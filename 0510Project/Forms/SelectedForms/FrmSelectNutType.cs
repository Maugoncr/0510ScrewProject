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
    public partial class FrmSelectNutType : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private NutsType MyNutsType { get; set; }
        public FrmSelectNutType()
        {
            InitializeComponent();

            MyNutsType = new NutsType();
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowNutsTypes(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowNutsTypes(true);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvWashersTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNutsTypes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvNutsTypes.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDNutsType"].Value);

                MyNutsType = NutsTypeLogic.Instancia.SelectByID(ID);

                txtIDNutType.Text = MyNutsType.IDNutsType.ToString();
                txtTypeName.Text = MyNutsType.NutsTypeName;

                Activar();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvNutsTypes.SelectedRows.Count > 0)
            {
                try
                {
                    FrmNuts.IDNutsType = Convert.ToInt32(dgvNutsTypes.SelectedRows[0].Cells["CIDNutsType"].Value);
                    FrmNuts.TypeName = Convert.ToString(dgvNutsTypes.SelectedRows[0].Cells["CNutsTypeName"].Value);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any type of nut.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSelectNutType_Load(object sender, EventArgs e)
        {
            ShowNutsTypes(true);

            CleanForm();
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDNutType.Clear();
            txtTypeName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyNutsType = new NutsType();
            Desactivar();
        }

        private void ShowNutsTypes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvNutsTypes.DataSource = NutsTypeLogic.Instancia.Listar(true, Filtro);

            dgvNutsTypes.ClearSelection();
        }

        public void Activar()
        {
            btnSelect.Enabled = true;
        }

        private void Desactivar()
        {
            btnSelect.Enabled = false;
        }


    }
}
