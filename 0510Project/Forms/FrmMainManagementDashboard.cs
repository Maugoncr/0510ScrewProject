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
    public partial class FrmMainManagementDashboard : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmMainManagementDashboard()
        {
            InitializeComponent();
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

        private void btnNuts_Click(object sender, EventArgs e)
        {
            using (FrmMainManagementNutsDB frm = new FrmMainManagementNutsDB())
            {
                frm.ShowDialog();
            }
        }

        private void btnWashers_Click(object sender, EventArgs e)
        {
            using (FrmMainManagementWashersDB frm = new FrmMainManagementWashersDB())
            {
                frm.ShowDialog();
            }
        }

        private void btnScrews_Click(object sender, EventArgs e)
        {
            using (FrmMainManagementScrewsDB frm = new FrmMainManagementScrewsDB())
            {
                frm.ShowDialog();
            }
        }
    }
}
