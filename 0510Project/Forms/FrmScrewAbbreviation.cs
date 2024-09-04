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
    public partial class FrmScrewAbbreviation : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewAbbreviation MyScrewAbbreviation { get; set; }


        public FrmScrewAbbreviation()
        {
            InitializeComponent();

            MyScrewAbbreviation = new ScrewAbbreviation();  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewAbbreviations(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewAbbreviations(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowScrewAbbreviations(checkActives.Checked);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAbbreviationName.Text))
            {
                MyScrewAbbreviation = new ScrewAbbreviation()
                {
                    AbbreviationName = txtAbbreviationName.Text,
                };


                bool respuesta = ScrewAbbreviationLogic.Instancia.Guardar(MyScrewAbbreviation);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewAbbreviations(checkActives.Checked);
                    MessageBox.Show("Screw Abbreviation Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("You cannot save an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAbbreviationName.Text))
            {
                MyScrewAbbreviation = new ScrewAbbreviation()
                {
                    IDScrewAbbreviation = int.Parse(txtIDScrewAbbreviation.Text),
                    AbbreviationName = txtAbbreviationName.Text
                };

                bool respuesta = ScrewAbbreviationLogic.Instancia.Editar(MyScrewAbbreviation);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewAbbreviations(checkActives.Checked);
                    MessageBox.Show("Screw Abbreviation Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ScrewAbbreviation TempObj = ScrewAbbreviationLogic.Instancia.SelectByID(Convert.ToInt32(txtIDScrewAbbreviation.Text));

            if (TempObj.IDScrewAbbreviation > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Screw Abbreviation: {0}?", txtIDScrewAbbreviation.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewAbbreviation = new ScrewAbbreviation
                        {
                            IDScrewAbbreviation = Convert.ToInt32(txtIDScrewAbbreviation.Text),
                            Active = 0
                        };

                        if (ScrewAbbreviationLogic.Instancia.Disable_Enable(MyScrewAbbreviation))
                        {
                            MessageBox.Show("Screw Abbreviation successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewAbbreviations(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Screw Abbreviation: {0}?", txtIDScrewAbbreviation.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewAbbreviation = new ScrewAbbreviation
                        {
                            IDScrewAbbreviation = Convert.ToInt32(txtIDScrewAbbreviation.Text),
                            Active = 1
                        };

                        if (ScrewAbbreviationLogic.Instancia.Disable_Enable(MyScrewAbbreviation))
                        {
                            MessageBox.Show("Screw Abbreviation successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewAbbreviations(checkActives.Checked);
                        }
                    }
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void FrmScrewAbbreviation_Load(object sender, EventArgs e)
        {
            ShowScrewAbbreviations(checkActives.Checked);

            CleanForm();
        }

        private void dgvScrewAbbreviations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewAbbreviations.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewAbbreviations.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrewAbbreviation"].Value);

                MyScrewAbbreviation = ScrewAbbreviationLogic.Instancia.SelectByID(ID);

                txtIDScrewAbbreviation.Text = MyScrewAbbreviation.IDScrewAbbreviation.ToString();
                txtAbbreviationName.Text = MyScrewAbbreviation.AbbreviationName;

                EnableUpdate_Disable();
            }
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtAbbreviationName.Clear();
            txtIDScrewAbbreviation.Clear();

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

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ShowScrewAbbreviations(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewAbbreviations.DataSource = ScrewAbbreviationLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvScrewAbbreviations.ClearSelection();
        }

    }
}
