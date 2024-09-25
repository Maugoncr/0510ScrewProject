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

namespace _0510Project.Forms
{
    public partial class FrmWasherSize : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private WasherSize MyWasherSize { get; set; }

        public FrmWasherSize()
        {
            InitializeComponent();

            MyWasherSize = new WasherSize();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWasherSize_Load(object sender, EventArgs e)
        {
            ShowWasherSizes(checkActives.Checked);
            CleanForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowWasherSizes(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowWasherSizes(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvWasherSizes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWasherSizes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvWasherSizes.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDWasherSize"].Value);

                MyWasherSize = WasherSizeLogic.Instancia.SelectByID(ID);

                txtIDWasherSize.Text = MyWasherSize.IDWasherSize.ToString();
                txtSizeName.Text = MyWasherSize.WasherSizeName;

                EnableUpdate_Disable();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSizeName.Text))
            {
                MyWasherSize = new WasherSize()
                {
                    WasherSizeName = txtSizeName.Text,
                };

                bool respuesta = WasherSizeLogic.Instancia.Guardar(MyWasherSize);

                if (respuesta)
                {
                    CleanForm();
                    ShowWasherSizes(checkActives.Checked);
                    MessageBox.Show("Washer Size Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot save an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSizeName.Text))
            {
                MyWasherSize = new WasherSize()
                {
                    IDWasherSize = int.Parse(txtIDWasherSize.Text),
                    WasherSizeName = txtSizeName.Text
                };

                bool respuesta = WasherSizeLogic.Instancia.Editar(MyWasherSize);

                if (respuesta)
                {
                    CleanForm();
                    ShowWasherSizes(checkActives.Checked);
                    MessageBox.Show("Washer Size Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            WasherSize TempObj = WasherSizeLogic.Instancia.SelectByID(Convert.ToInt32(txtIDWasherSize.Text));

            if (TempObj.IDWasherSize > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Washer Size: {0}?", txtIDWasherSize.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyWasherSize = new WasherSize
                        {
                            IDWasherSize = Convert.ToInt32(txtIDWasherSize.Text),
                            Active = 0
                        };

                        if (WasherSizeLogic.Instancia.Disable_Enable(MyWasherSize))
                        {
                            MessageBox.Show("Washer Size successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowWasherSizes(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Washer Size: {0}?", txtIDWasherSize.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyWasherSize = new WasherSize
                        {
                            IDWasherSize = Convert.ToInt32(txtIDWasherSize.Text),
                            Active = 1
                        };

                        if (WasherSizeLogic.Instancia.Disable_Enable(MyWasherSize))
                        {
                            MessageBox.Show("Washer Size successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowWasherSizes(checkActives.Checked);
                        }
                    }
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowWasherSizes(checkActives.Checked);

            if (checkActives.Checked)
            {
                btnDisable.Text = "     Disable";

                btnDisable.IconChar = FontAwesome.Sharp.IconChar.Ban;
            }
            else
            {

                btnDisable.Text = "     Enable";

                btnDisable.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            }
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDWasherSize.Clear();
            txtSizeName.Clear();

            if (cleanSearch)
            {
                txtFilter.Text = "Search...";
            }

            EnableSave();
        }

        private void EnableSave()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDisable.Enabled = false;
        }

        private void EnableUpdate_Disable()
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDisable.Enabled = true;
        }

        private void ShowWasherSizes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvWasherSizes.DataSource = WasherSizeLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvWasherSizes.ClearSelection();
        }
    }
}
