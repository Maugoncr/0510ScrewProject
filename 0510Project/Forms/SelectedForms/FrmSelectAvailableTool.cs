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
    public partial class FrmSelectAvailableTool : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public ScrewAvailableTool _MyScrewAvailableTool { get; set; }

        public FrmSelectAvailableTool()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewAvailableTools(true, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewAvailableTools(true);
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

        private void FrmSelectAvailableTool_Load(object sender, EventArgs e)
        {
            ShowScrewAvailableTools(true);
        }

        private void ShowScrewAvailableTools(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewAvailableTools.DataSource = ScrewAvailableToolLogic.Instancia.Listar(SeeActives, Filtro);

            dgvScrewAvailableTools.ClearSelection();
        }

        private void dgvScrewAvailableTools_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol >= 0)
            {
                _MyScrewAvailableTool = new ScrewAvailableTool()
                {
                    IDScrewTool = Convert.ToInt32(dgvScrewAvailableTools.Rows[iRow].Cells["CIDScrewTool"].Value.ToString()),
                    ToolName = dgvScrewAvailableTools.Rows[iRow].Cells["CToolName"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
