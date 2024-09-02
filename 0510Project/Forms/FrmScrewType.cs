using Logica.Logic;
using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0510Project.Forms
{
    public partial class FrmScrewType : Form
    {
        private ScrewType MyScrewType { get; set; }

        public FrmScrewType()
        {
            InitializeComponent();

            MyScrewType = new ScrewType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmScrewType_Load(object sender, EventArgs e)
        {
            ShowScrewTypes(checkActives.Checked);

            CleanForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTypeName.Text))
            {
                MyScrewType = new ScrewType()
                {
                    TypeName = txtTypeName.Text,
                };


                bool respuesta = ScrewTypeLogic.Instancia.Guardar(MyScrewType);

                if (respuesta)
                {
                   CleanForm();
                   ShowScrewTypes(checkActives.Checked);
                   MessageBox.Show("Screw Type Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("You cannot save an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrewType.Clear();
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

        private void ShowScrewTypes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewTypes.DataSource = ScrewTypeLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvScrewTypes.ClearSelection();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewTypes(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewTypes(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowScrewTypes(checkActives.Checked);

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

        private void dgvScrewTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewTypes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewTypes.SelectedRows[0];

                int IDScrewType = Convert.ToInt32(MyRow.Cells["CIDScrewType"].Value);

                MyScrewType = ScrewTypeLogic.Instancia.SelectByID(IDScrewType);

                txtIDScrewType.Text = MyScrewType.IDScrewType.ToString();
                txtTypeName.Text = MyScrewType.TypeName;

                EnableUpdate_Disable();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTypeName.Text))
            {
                MyScrewType = new ScrewType()
                {
                    IDScrewType = int.Parse(txtIDScrewType.Text),
                    TypeName = txtTypeName.Text
                };

                bool respuesta = ScrewTypeLogic.Instancia.Editar(MyScrewType);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewTypes(checkActives.Checked);
                    MessageBox.Show("Screw Type Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ScrewType TempObj = ScrewTypeLogic.Instancia.SelectByID(Convert.ToInt32(txtIDScrewType.Text));

            if (TempObj.IDScrewType > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Screw Type: {0}?", txtIDScrewType.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewType = new ScrewType
                        {
                            IDScrewType = Convert.ToInt32(txtIDScrewType.Text),
                            Active = 0
                        };

                        if (ScrewTypeLogic.Instancia.Disable_Enable(MyScrewType))
                        {
                            MessageBox.Show("Screw Type successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewTypes(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Screw Type: {0}?", txtIDScrewType.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewType = new ScrewType
                        {
                            IDScrewType = Convert.ToInt32(txtIDScrewType.Text),
                            Active = 1
                        };

                        if (ScrewTypeLogic.Instancia.Disable_Enable(MyScrewType))
                        {
                            MessageBox.Show("Screw Type successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewTypes(checkActives.Checked);
                        }
                    }
                }
            }


        }
    }
}
