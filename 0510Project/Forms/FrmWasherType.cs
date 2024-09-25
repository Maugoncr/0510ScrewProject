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
    public partial class FrmWasherType : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private WasherType MyWasherType { get; set; }

        public FrmWasherType()
        {
            InitializeComponent();

            MyWasherType = new WasherType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWasherType_Load(object sender, EventArgs e)
        {
            ShowWasherTypes(checkActives.Checked);
            CleanForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowWasherTypes(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowWasherTypes(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvNutsTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWashersTypes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvWashersTypes.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDWasherType"].Value);

                MyWasherType = WasherTypeLogic.Instancia.SelectByID(ID);

                txtIDWasherType.Text = MyWasherType.IDWasherType.ToString();
                txtTypeName.Text = MyWasherType.WasherTypeName;

                EnableUpdate_Disable();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTypeName.Text))
            {
                MyWasherType = new WasherType()
                {
                    WasherTypeName = txtTypeName.Text,
                };

                bool respuesta = WasherTypeLogic.Instancia.Guardar(MyWasherType);

                if (respuesta)
                {
                    CleanForm();
                    ShowWasherTypes(checkActives.Checked);
                    MessageBox.Show("Washer Type Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot save an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTypeName.Text))
            {
                MyWasherType = new WasherType()
                {
                    IDWasherType = int.Parse(txtIDWasherType.Text),
                    WasherTypeName = txtTypeName.Text
                };

                bool respuesta = WasherTypeLogic.Instancia.Editar(MyWasherType);

                if (respuesta)
                {
                    CleanForm();
                    ShowWasherTypes(checkActives.Checked);
                    MessageBox.Show("Washer Type Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            WasherType TempObj = WasherTypeLogic.Instancia.SelectByID(Convert.ToInt32(txtIDWasherType.Text));

            if (TempObj.IDWasherType > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Washer Type: {0}?", txtIDWasherType.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyWasherType = new WasherType
                        {
                            IDWasherType = Convert.ToInt32(txtIDWasherType.Text),
                            Active = 0
                        };

                        if (WasherTypeLogic.Instancia.Disable_Enable(MyWasherType))
                        {
                            MessageBox.Show("Washer Type successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowWasherTypes(checkActives.Checked);
                        }
                    }
                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Washer Type: {0}?", txtIDWasherType.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyWasherType = new WasherType
                        {
                            IDWasherType = Convert.ToInt32(txtIDWasherType.Text),
                            Active = 1
                        };

                        if (WasherTypeLogic.Instancia.Disable_Enable(MyWasherType))
                        {
                            MessageBox.Show("Washer Type successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowWasherTypes(checkActives.Checked);
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
            ShowWasherTypes(checkActives.Checked);

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

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDWasherType.Clear();
            txtTypeName.Clear();

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

        private void ShowWasherTypes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvWashersTypes.DataSource = WasherTypeLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvWashersTypes.ClearSelection();
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
