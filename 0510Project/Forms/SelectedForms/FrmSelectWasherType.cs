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
    public partial class FrmSelectWasherType : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private WasherType MyWasherType { get; set; }

        public FrmSelectWasherType()
        {
            InitializeComponent();

            MyWasherType = new WasherType();
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
                ShowWasherTypes(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowWasherTypes(true);
            }
        }

        private void FrmSelectWasherType_Load(object sender, EventArgs e)
        {
            ShowWasherTypes(true);

            CleanForm();
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvWashersTypes.SelectedRows.Count > 0)
            {
                try
                {
                    FrmWashers.IDWasherType = Convert.ToInt32(dgvWashersTypes.SelectedRows[0].Cells["CIDWasherType"].Value);
                    FrmWashers.TypeName = Convert.ToString(dgvWashersTypes.SelectedRows[0].Cells["CWasherTypeName"].Value);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any type of washer.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvWashersTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvWashersTypes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvWashersTypes.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDWasherType"].Value);

                MyWasherType = WasherTypeLogic.Instancia.SelectByID(ID);

                txtIDWasherType.Text = MyWasherType.IDWasherType.ToString();
                txtTypeName.Text = MyWasherType.WasherTypeName;

                Activar();
            }
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDWasherType.Clear();
            txtTypeName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            MyWasherType = new WasherType();
            Desactivar();
        }

        private void ShowWasherTypes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvWashersTypes.DataSource = WasherTypeLogic.Instancia.Listar(true, Filtro);

            dgvWashersTypes.ClearSelection();
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
