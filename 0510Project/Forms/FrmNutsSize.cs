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
    public partial class FrmNutsSize : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private NutsSize MyNutsSize { get; set; }

        public FrmNutsSize()
        {
            InitializeComponent();

            MyNutsSize = new NutsSize();
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

        private void FrmNutsSize_Load(object sender, EventArgs e)
        {
            ShowNutsSizes(checkActives.Checked);

            CleanForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowNutsSizes(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowNutsSizes(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvNutsSizes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNutsSizes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvNutsSizes.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDNutsSize"].Value);

                MyNutsSize = NutsSizeLogic.Instancia.SelectByID(ID);

                txtIDNutsSize.Text = MyNutsSize.IDNutsSize.ToString();
                txtSizeName.Text = MyNutsSize.NutsSizeName;

                EnableUpdate_Disable();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSizeName.Text))
            {
                MyNutsSize = new NutsSize()
                {
                    NutsSizeName = txtSizeName.Text,
                };


                bool respuesta = NutsSizeLogic.Instancia.Guardar(MyNutsSize);

                if (respuesta)
                {
                    CleanForm();
                    ShowNutsSizes(checkActives.Checked);
                    MessageBox.Show("Nut Size Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("You cannot save an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            NutsSize TempObj = NutsSizeLogic.Instancia.SelectByID(Convert.ToInt32(txtIDNutsSize.Text));

            if (TempObj.IDNutsSize > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Nut Size: {0}?", txtIDNutsSize.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyNutsSize = new NutsSize
                        {
                            IDNutsSize = Convert.ToInt32(txtIDNutsSize.Text),
                            Active = 0
                        };

                        if (NutsSizeLogic.Instancia.Disable_Enable(MyNutsSize))
                        {
                            MessageBox.Show("Nut Size successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowNutsSizes(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Nut Size: {0}?", txtIDNutsSize.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyNutsSize = new NutsSize
                        {
                            IDNutsSize = Convert.ToInt32(txtIDNutsSize.Text),
                            Active = 1
                        };

                        if (NutsSizeLogic.Instancia.Disable_Enable(MyNutsSize))
                        {
                            MessageBox.Show("Nut Size successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowNutsSizes(checkActives.Checked);
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSizeName.Text))
            {
                MyNutsSize = new NutsSize()
                {
                    IDNutsSize = int.Parse(txtIDNutsSize.Text),
                    NutsSizeName = txtSizeName.Text
                };

                bool respuesta = NutsSizeLogic.Instancia.Editar(MyNutsSize);

                if (respuesta)
                {
                    CleanForm();
                    ShowNutsSizes(checkActives.Checked);
                    MessageBox.Show("Nut Size Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowNutsSizes(checkActives.Checked);

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
            txtIDNutsSize.Clear();
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

        private void ShowNutsSizes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvNutsSizes.DataSource = NutsSizeLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvNutsSizes.ClearSelection();
        }
    }
}
