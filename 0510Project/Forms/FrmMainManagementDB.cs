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
    public partial class FrmMainManagementDB : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmMainManagementDB()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMainManagementDB_Load(object sender, EventArgs e)
        {
            
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picMaterials_Click(object sender, EventArgs e)
        {
            using (FrmScrewMaterial frm = new FrmScrewMaterial())
            {
                frm.ShowDialog();
            }
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            using (FrmScrewMaterial frm = new FrmScrewMaterial())
            {
                frm.ShowDialog();
            }
        }

        private void picAvailableTools_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WORK IN PROGRESS", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAvailableTools_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WORK IN PROGRESS", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void picNTools_Click(object sender, EventArgs e)
        {
            using (FrmScrewNTool frm = new FrmScrewNTool())
            {
                frm.ShowDialog();
            }
        }

        private void btnNTools_Click(object sender, EventArgs e)
        {
            using (FrmScrewNTool frm = new FrmScrewNTool())
            {
                frm.ShowDialog();
            }
        }

        private void picAbbreviations_Click(object sender, EventArgs e)
        {
            using (FrmScrewAbbreviation frm = new FrmScrewAbbreviation())
            {
                frm.ShowDialog();
            }
        }

        private void btnAbbreviations_Click(object sender, EventArgs e)
        {
            using (FrmScrewAbbreviation frm = new FrmScrewAbbreviation())
            {
                frm.ShowDialog();
            }
        }

        private void picSize_Click(object sender, EventArgs e)
        {
            using (FrmScrewSize frm = new FrmScrewSize())
            {
                frm.ShowDialog();
            }
        }

        private void btnSizes_Click(object sender, EventArgs e)
        {
            using (FrmScrewSize frm = new FrmScrewSize())
            {
                frm.ShowDialog();
            }
        }

        private void picLength_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WORK IN PROGRESS", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLengths_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WORK IN PROGRESS", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void picTypes_Click(object sender, EventArgs e)
        {
            using (FrmScrewType frm = new FrmScrewType())
            {
                frm.ShowDialog();
            }
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            using (FrmScrewType frm = new FrmScrewType())
            {
                frm.ShowDialog();
            }
        }

        private void picScrews_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WORK IN PROGRESS", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnScrews_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WORK IN PROGRESS", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
