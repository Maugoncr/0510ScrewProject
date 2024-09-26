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
    public partial class FrmMainManagementWashersDB : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmMainManagementWashersDB()
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

        private void btnWasherType_Click(object sender, EventArgs e)
        {
            using (FrmWasherType frm = new FrmWasherType())
            {
                frm.ShowDialog();
            }
        }

        private void picWasherType_Click(object sender, EventArgs e)
        {
            using (FrmWasherType frm = new FrmWasherType())
            {
                frm.ShowDialog();
            }
        }

        private void btnWasherSize_Click(object sender, EventArgs e)
        {
            using (FrmWasherSize frm = new FrmWasherSize())
            {
                frm.ShowDialog();
            }
        }

        private void picWasherSize_Click(object sender, EventArgs e)
        {
            using (FrmWasherSize frm = new FrmWasherSize())
            {
                frm.ShowDialog();
            }
        }

        private void btnWasher_Click(object sender, EventArgs e)
        {
            using (FrmWashers frm = new FrmWashers())
            {
                frm.ShowDialog();
            }
        }

        private void picWasher_Click(object sender, EventArgs e)
        {
            using (FrmWashers frm = new FrmWashers())
            {
                frm.ShowDialog();
            }
        }
    }
}
