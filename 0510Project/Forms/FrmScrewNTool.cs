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
    public partial class FrmScrewNTool : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewNTool MyScrewNTool { get; set; }


        public FrmScrewNTool()
        {
            InitializeComponent();

            MyScrewNTool = new ScrewNTool();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewNTools(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewNTools(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvScrewNTools_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewNTools.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewNTools.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrewNTool"].Value);

                MyScrewNTool = ScrewNToolLogic.Instancia.SelectByID(ID);

                txtIDScrewNTool.Text = MyScrewNTool.IDScrewNTool.ToString();
                txtNToolName.Text = MyScrewNTool.NToolName;

                EnableUpdate_Disable();
            }
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowScrewNTools(checkActives.Checked);

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
            if (!string.IsNullOrEmpty(txtNToolName.Text))
            {
                MyScrewNTool = new ScrewNTool()
                {
                    NToolName = txtNToolName.Text,
                };


                bool respuesta = ScrewNToolLogic.Instancia.Guardar(MyScrewNTool);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewNTools(checkActives.Checked);
                    MessageBox.Show("Screw Number Tool Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("You cannot save an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNToolName.Text))
            {
                MyScrewNTool = new ScrewNTool()
                {
                    IDScrewNTool = int.Parse(txtIDScrewNTool.Text),
                    NToolName = txtNToolName.Text
                };

                bool respuesta = ScrewNToolLogic.Instancia.Editar(MyScrewNTool);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewNTools(checkActives.Checked);
                    MessageBox.Show("Screw Number Tool Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ScrewNTool TempObj = ScrewNToolLogic.Instancia.SelectByID(Convert.ToInt32(txtIDScrewNTool.Text));

            if (TempObj.IDScrewNTool > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Screw Number Tool: {0}?", txtIDScrewNTool.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewNTool = new ScrewNTool
                        {
                            IDScrewNTool = Convert.ToInt32(txtIDScrewNTool.Text),
                            Active = 0
                        };

                        if (ScrewNToolLogic.Instancia.Disable_Enable(MyScrewNTool))
                        {
                            MessageBox.Show("Screw Number Tool successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewNTools(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Screw Number Tool: {0}?", txtIDScrewNTool.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewNTool = new ScrewNTool
                        {
                            IDScrewNTool = Convert.ToInt32(txtIDScrewNTool.Text),
                            Active = 1
                        };

                        if (ScrewNToolLogic.Instancia.Disable_Enable(MyScrewNTool))
                        {
                            MessageBox.Show("Screw Number Tool successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewNTools(checkActives.Checked);
                        }
                    }
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void FrmScrewNTool_Load(object sender, EventArgs e)
        {
            ShowScrewNTools(checkActives.Checked);

            CleanForm();
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ShowScrewNTools(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewNTools.DataSource = ScrewNToolLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvScrewNTools.ClearSelection();
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrewNTool.Clear();
            txtNToolName.Clear();

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

    }
}
