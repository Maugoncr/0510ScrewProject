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

namespace _0510Project.Forms
{
    public partial class FrmUpdateDataBase : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmUpdateDataBase()
        {
            InitializeComponent();
        }

        private void FrmUpdateDataBase_Load(object sender, EventArgs e)
        {
            lbWhoAreYou.Text = "User: " + GetUserName() + "\nSystem: " + GetMachineName() + "\nIP: " + GetIPAddress()
                + "\nOS: " + GetOSVersion() + "\nUserDomain: " + GetUserDomain();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GetUserDomain()
        {
            return Environment.UserDomainName;
        }

        public static string GetUserName()
        {
            return Environment.UserName;
        }

        public static string GetOSVersion()
        {
            return Environment.OSVersion.ToString();
        }

        public static string GetMachineName()
        {
            return Environment.MachineName;
        }

        public static string GetIPAddress()
        {
            string hostName = Dns.GetHostName(); // Obtener el nombre del host
            IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                if (addr[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return addr[i].ToString();
                }
            }

            return "No IP Address Found";
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
