using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0510Project.Forms
{
    public partial class FrmWashers : Form
    {
        public FrmWashers()
        {
            InitializeComponent();
        }

        private void btnFormSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWashers_Load(object sender, EventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvWashers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIDWasherType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDWasherSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectWasherType_Click(object sender, EventArgs e)
        {

        }

        private void btnClearWasherType_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectWasherSize_Click(object sender, EventArgs e)
        {

        }

        private void btnClearWasherSize_Click(object sender, EventArgs e)
        {

        }

        private void txtSSNEPartNumber_Leave(object sender, EventArgs e)
        {

        }

        private void txtVendorPartNumber_Leave(object sender, EventArgs e)
        {

        }

        private void txtUrlPDF_Leave(object sender, EventArgs e)
        {

        }

        private void txtUrlSTEP_Leave(object sender, EventArgs e)
        {

        }

        private void btnCheckUrlPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckUrlSTEP_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }
    }
}
