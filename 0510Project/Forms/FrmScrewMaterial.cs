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
    public partial class FrmScrewMaterial : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewMaterial MyScrewMaterial { get; set; }

        public FrmScrewMaterial()
        {
            InitializeComponent();

            MyScrewMaterial = new ScrewMaterial();
        }

        private void FrmScrewMaterial_Load(object sender, EventArgs e)
        {
            ShowScrewMaterials(checkActives.Checked);

            CleanForm();
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrewMaterial.Clear();
            txtMaterialName.Clear();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewMaterials(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewMaterials(checkActives.Checked);
            }
        }

        private void ShowScrewMaterials(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewMaterials.DataSource = ScrewMaterialLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvScrewMaterials.ClearSelection();
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvScrewMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewMaterials.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewMaterials.SelectedRows[0];

                int IDScrewMaterial = Convert.ToInt32(MyRow.Cells["CIDScrewMaterial"].Value);

                MyScrewMaterial = ScrewMaterialLogic.Instancia.SelectByID(IDScrewMaterial);

                txtIDScrewMaterial.Text = MyScrewMaterial.IDScrewMaterial.ToString();
                txtMaterialName.Text = MyScrewMaterial.MaterialName;

                EnableUpdate_Disable();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaterialName.Text))
            {
                MyScrewMaterial = new ScrewMaterial()
                {
                    MaterialName = txtMaterialName.Text,
                };


                bool respuesta = ScrewMaterialLogic.Instancia.Guardar(MyScrewMaterial);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewMaterials(checkActives.Checked);
                    MessageBox.Show("Screw Material Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("You cannot save an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaterialName.Text))
            {
                MyScrewMaterial = new ScrewMaterial()
                {
                    IDScrewMaterial = int.Parse(txtIDScrewMaterial.Text),
                    MaterialName = txtMaterialName.Text
                };

                bool respuesta = ScrewMaterialLogic.Instancia.Editar(MyScrewMaterial);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewMaterials(checkActives.Checked);
                    MessageBox.Show("Screw Material Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ScrewMaterial TempObj = ScrewMaterialLogic.Instancia.SelectByID(Convert.ToInt32(txtIDScrewMaterial.Text));

            if (TempObj.IDScrewMaterial > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Screw Material: {0}?", txtIDScrewMaterial.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewMaterial = new ScrewMaterial
                        {
                            IDScrewMaterial = Convert.ToInt32(txtIDScrewMaterial.Text),
                            Active = 0
                        };

                        if (ScrewMaterialLogic.Instancia.Disable_Enable(MyScrewMaterial))
                        {
                            MessageBox.Show("Screw Material successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewMaterials(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Screw Material: {0}?", txtIDScrewMaterial.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewMaterial = new ScrewMaterial
                        {
                            IDScrewMaterial = Convert.ToInt32(txtIDScrewMaterial.Text),
                            Active = 1
                        };

                        if (ScrewMaterialLogic.Instancia.Disable_Enable(MyScrewMaterial))
                        {
                            MessageBox.Show("Screw Material successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewMaterials(checkActives.Checked);
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
            ShowScrewMaterials(checkActives.Checked);

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
    }
}
