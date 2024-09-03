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
    public partial class FrmScrewSize : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewSize MyScrewSize { get; set; }

        public FrmScrewSize()
        {
            InitializeComponent();

            MyScrewSize = new ScrewSize();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSizeName.Text))
            {
                MyScrewSize = new ScrewSize()
                {
                    SizeName = txtSizeName.Text,
                };


                bool respuesta = ScrewSizeLogic.Instancia.Guardar(MyScrewSize);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewSizes(checkActives.Checked);
                    MessageBox.Show("Screw Size Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MyScrewSize = new ScrewSize()
                {
                    IDScrewSize = int.Parse(txtIDScrewSize.Text),
                    SizeName = txtSizeName.Text
                };

                bool respuesta = ScrewSizeLogic.Instancia.Editar(MyScrewSize);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewSizes(checkActives.Checked);
                    MessageBox.Show("Screw Size Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ScrewSize TempObj = ScrewSizeLogic.Instancia.SelectByID(Convert.ToInt32(txtIDScrewSize.Text));

            if (TempObj.IDScrewSize > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Screw Size: {0}?", txtIDScrewSize.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewSize = new ScrewSize
                        {
                            IDScrewSize = Convert.ToInt32(txtIDScrewSize.Text),
                            Active = 0
                        };

                        if (ScrewSizeLogic.Instancia.Disable_Enable(MyScrewSize))
                        {
                            MessageBox.Show("Screw Size successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewSizes(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Screw Size: {0}?", txtIDScrewSize.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewSize = new ScrewSize
                        {
                            IDScrewSize = Convert.ToInt32(txtIDScrewSize.Text),
                            Active = 1
                        };

                        if (ScrewSizeLogic.Instancia.Disable_Enable(MyScrewSize))
                        {
                            MessageBox.Show("Screw Size successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewSizes(checkActives.Checked);
                        }
                    }
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void FrmScrewSize_Load(object sender, EventArgs e)
        {
            ShowScrewSizes(checkActives.Checked);

            CleanForm();
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrewSize.Clear();
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

        private void ShowScrewSizes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewSizes.DataSource = ScrewSizeLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvScrewSizes.ClearSelection();
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewSizes(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewSizes(checkActives.Checked);
            }
        }

        private void dgvScrewSizes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewSizes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewSizes.SelectedRows[0];

                int IDScrewSize = Convert.ToInt32(MyRow.Cells["CIDScrewSize"].Value);

                MyScrewSize = ScrewSizeLogic.Instancia.SelectByID(IDScrewSize);

                txtIDScrewSize.Text = MyScrewSize.IDScrewSize.ToString();
                txtSizeName.Text = MyScrewSize.SizeName;

                EnableUpdate_Disable();
            }
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowScrewSizes(checkActives.Checked);

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
    }
}
