using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace _0510Project.Forms
{
    public partial class FrmInformation : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmInformation()
        {
            InitializeComponent();
        }

        private void btnDownloadFonts_Click(object sender, EventArgs e)
        {
            string url = "https://drive.google.com/drive/folders/1V9cNij-mJgEIcTtdqY9EQDdleLHgF5dQ?usp=drive_link";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void btnDownloadWebView2_Click(object sender, EventArgs e)
        {
            string url = "https://drive.google.com/drive/folders/1NO0FUk0hZ3DMTLSi4DzlW5jfRjPUw69G?usp=drive_link";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDownloadDataBase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("𝐀𝐫𝐞 𝐲𝐨𝐮 𝐚𝐛𝐬𝐨𝐥𝐮𝐭𝐞𝐥𝐲 𝐬𝐮𝐫𝐞 𝐲𝐨𝐮 𝐤𝐧𝐨𝐰 𝐰𝐡𝐚𝐭 𝐲𝐨𝐮'𝐫𝐞 𝐝𝐨𝐢𝐧𝐠 𝐚𝐧𝐝 𝐡𝐚𝐯𝐞 𝐩𝐫𝐨𝐩𝐞𝐫 𝐚𝐮𝐭𝐡𝐨𝐫𝐢𝐳𝐚𝐭𝐢𝐨𝐧 𝐭𝐨 𝐩𝐫𝐨𝐜𝐞𝐞𝐝?\n\n𝐁𝐲 𝐬𝐞𝐥𝐞𝐜𝐭𝐢𝐧𝐠 𝐘𝐄𝐒, 𝐲𝐨𝐮 𝐚𝐜𝐤𝐧𝐨𝐰𝐥𝐞𝐝𝐠𝐞 𝐭𝐡𝐚𝐭 𝐲𝐨𝐮𝐫 𝐢𝐧𝐟𝐨𝐫𝐦𝐚𝐭𝐢𝐨𝐧 𝐚𝐧𝐝 𝐭𝐡𝐢𝐬 𝐚𝐜𝐭𝐢𝐨𝐧 𝐰𝐢𝐥𝐥 𝐛𝐞 𝐫𝐞𝐩𝐨𝐫𝐭𝐞𝐝 𝐭𝐨 𝐭𝐡𝐞 𝐚𝐝𝐦𝐢𝐧𝐢𝐬𝐭𝐫𝐚𝐭𝐨𝐫𝐬.",
                                         "𝐖𝐀𝐑𝐍𝐈𝐍𝐆",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (FrmUpdateDataBase frm = new FrmUpdateDataBase())
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
