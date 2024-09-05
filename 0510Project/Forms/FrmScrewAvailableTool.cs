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
    public partial class FrmScrewAvailableTool : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewAvailableTool MyScrewAvailableTool { get; set; }

        public FrmScrewAvailableTool()
        {
            InitializeComponent();

            MyScrewAvailableTool = new ScrewAvailableTool();    
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
                ShowScrewAvailableTools(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewAvailableTools(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvScrewAvailableTools_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewAvailableTools.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewAvailableTools.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrewTool"].Value);

                MyScrewAvailableTool = ScrewAvailableToolLogic.Instancia.SelectByID(ID);

                txtIDScrewTool.Text = MyScrewAvailableTool.IDScrewTool.ToString();
                txtToolName.Text = MyScrewAvailableTool.ToolName;

                EnableUpdate_Disable();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtToolName.Text))
            {
                MyScrewAvailableTool = new ScrewAvailableTool()
                {
                    ToolName = txtToolName.Text,
                };


                bool respuesta = ScrewAvailableToolLogic.Instancia.Guardar(MyScrewAvailableTool);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewAvailableTools(checkActives.Checked);
                    MessageBox.Show("Screw Available Tool Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("You cannot save an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowScrewAvailableTools(checkActives.Checked);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtToolName.Text))
            {
                MyScrewAvailableTool = new ScrewAvailableTool()
                {
                    IDScrewTool = int.Parse(txtIDScrewTool.Text),
                    ToolName = txtToolName.Text
                };

                bool respuesta = ScrewAvailableToolLogic.Instancia.Editar(MyScrewAvailableTool);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewAvailableTools(checkActives.Checked);
                    MessageBox.Show("Screw Available Tool Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ScrewAvailableTool TempObj = ScrewAvailableToolLogic.Instancia.SelectByID(Convert.ToInt32(txtIDScrewTool.Text));

            if (TempObj.IDScrewTool > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Screw Available Tool: {0}?", txtIDScrewTool.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewAvailableTool = new ScrewAvailableTool
                        {
                            IDScrewTool = Convert.ToInt32(txtIDScrewTool.Text),
                            Active = 0
                        };

                        if (ScrewAvailableToolLogic.Instancia.Disable_Enable(MyScrewAvailableTool))
                        {
                            MessageBox.Show("Screw Available Tool successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewAvailableTools(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Screw Available Tool: {0}?", txtIDScrewTool.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewAvailableTool = new ScrewAvailableTool
                        {
                            IDScrewTool = Convert.ToInt32(txtIDScrewTool.Text),
                            Active = 1
                        };

                        if (ScrewAvailableToolLogic.Instancia.Disable_Enable(MyScrewAvailableTool))
                        {
                            MessageBox.Show("Screw Available Tool successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewAvailableTools(checkActives.Checked);
                        }
                    }
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void FrmScrewAvailableTool_Load(object sender, EventArgs e)
        {
            ShowScrewAvailableTools(checkActives.Checked);

            CleanForm();
        }

        private void ShowScrewAvailableTools(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewAvailableTools.DataSource = ScrewAvailableToolLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvScrewAvailableTools.ClearSelection();
        }

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrewTool.Clear();
            txtToolName.Clear();

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
