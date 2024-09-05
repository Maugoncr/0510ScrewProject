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
    public partial class FrmScrewLength : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ScrewLength MyScrewLength { get; set; }

        public FrmScrewLength()
        {
            InitializeComponent();

            MyScrewLength = new ScrewLength();

        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowScrewLength(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowScrewLength(checkActives.Checked);
            }
        }

        private void ShowScrewLength(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvScrewLengths.DataSource = ScrewLengthLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvScrewLengths.ClearSelection();
        }

        private void FrmScrewLength_Load(object sender, EventArgs e)
        {
            ShowScrewLength(checkActives.Checked);

            CleanForm();
        }

        private void dgvScrewLengths_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScrewLengths.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvScrewLengths.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDScrewLength"].Value);

                MyScrewLength = ScrewLengthLogic.Instancia.SelectByID(ID);

                txtIDScrewLength.Text = MyScrewLength.IDScrewLength.ToString();

                txtLengthInch.Text = MyScrewLength.LengthInch;
                txtLengthDecimal.Text = MyScrewLength.LengthDecimal;
                txtLengthMetric.Text = MyScrewLength.LengthMetric;

                EnableUpdate_Disable();
            }
        }

        private void checkActives_CheckedChanged(object sender, EventArgs e)
        {
            ShowScrewLength(checkActives.Checked);

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
            if (!string.IsNullOrEmpty(txtLengthInch.Text) && !string.IsNullOrEmpty(txtLengthDecimal.Text) && !string.IsNullOrEmpty(txtLengthMetric.Text))
            {
                MyScrewLength = new ScrewLength()
                {
                    LengthInch = txtLengthInch.Text,
                    LengthDecimal = txtLengthDecimal.Text,
                    LengthMetric = txtLengthMetric.Text,
                };

                bool respuesta = ScrewLengthLogic.Instancia.Guardar(MyScrewLength);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewLength(checkActives.Checked);
                    MessageBox.Show("Screw Length Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot save an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLengthInch.Text) && !string.IsNullOrEmpty(txtLengthDecimal.Text) && !string.IsNullOrEmpty(txtLengthMetric.Text))
            {
                MyScrewLength = new ScrewLength()
                {
                    IDScrewLength = int.Parse(txtIDScrewLength.Text),
                    LengthInch = txtLengthInch.Text,
                    LengthDecimal = txtLengthDecimal.Text,
                    LengthMetric = txtLengthMetric.Text,
                };

                bool respuesta = ScrewLengthLogic.Instancia.Editar(MyScrewLength);

                if (respuesta)
                {
                    CleanForm();
                    ShowScrewLength(checkActives.Checked);
                    MessageBox.Show("Screw Length Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ScrewLength TempObj = ScrewLengthLogic.Instancia.SelectByID(Convert.ToInt32(txtIDScrewLength.Text));

            if (TempObj.IDScrewLength > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Screw Length: {0}?", txtIDScrewLength.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewLength = new ScrewLength
                        {
                            IDScrewLength = Convert.ToInt32(txtIDScrewLength.Text),
                            Active = 0
                        };

                        if (ScrewLengthLogic.Instancia.Disable_Enable(MyScrewLength))
                        {
                            MessageBox.Show("Screw Length successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewLength(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Screw Length: {0}?", txtIDScrewLength.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyScrewLength = new ScrewLength
                        {
                            IDScrewLength = Convert.ToInt32(txtIDScrewLength.Text),
                            Active = 1
                        };

                        if (ScrewLengthLogic.Instancia.Disable_Enable(MyScrewLength))
                        {
                            MessageBox.Show("Screw Length successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowScrewLength(checkActives.Checked);
                        }
                    }
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
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

        private void CleanForm(bool cleanSearch = true)
        {
            txtIDScrewLength.Clear();
            txtLengthInch.Clear();
            txtLengthDecimal.Clear();
            txtLengthMetric.Clear();

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
