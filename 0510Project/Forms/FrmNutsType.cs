using Logica.Logic;
using Logica.Models;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _0510Project.Forms
{
    public partial class FrmNutsType : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private NutsType MyNutsType { get; set; }

        public FrmNutsType()
        {
            InitializeComponent();

            MyNutsType = new NutsType();
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

        private void FrmNutsType_Load(object sender, EventArgs e)
        {
            ShowNutsTypes(checkActives.Checked);

            CleanForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && txtFilter.Text.Count() >= 2)
            {
                ShowNutsTypes(checkActives.Checked, txtFilter.Text.Trim());
            }
            else
            {
                ShowNutsTypes(checkActives.Checked);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void dgvNutsTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNutsTypes.SelectedRows.Count == 1)
            {
                CleanForm(false);

                DataGridViewRow MyRow = dgvNutsTypes.SelectedRows[0];

                int ID = Convert.ToInt32(MyRow.Cells["CIDNutsType"].Value);

                MyNutsType = NutsTypeLogic.Instancia.SelectByID(ID);

                txtIDNutsType.Text = MyNutsType.IDNutsType.ToString();
                txtTypeName.Text = MyNutsType.NutsTypeName;

                EnableUpdate_Disable();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtTypeName.Text))
            {
                MyNutsType = new NutsType()
                {
                    NutsTypeName = txtTypeName.Text,
                };

                bool respuesta = NutsTypeLogic.Instancia.Guardar(MyNutsType);

                if (respuesta)
                {
                    CleanForm();
                    ShowNutsTypes(checkActives.Checked);
                    MessageBox.Show("Nut Type Added Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MyNutsType = new NutsType()
                {
                    IDNutsType = int.Parse(txtIDNutsType.Text),
                    NutsTypeName = txtTypeName.Text
                };

                bool respuesta = NutsTypeLogic.Instancia.Editar(MyNutsType);

                if (respuesta)
                {
                    CleanForm();
                    ShowNutsTypes(checkActives.Checked);
                    MessageBox.Show("Nut Type Updated Correctly", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot update an empty record.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            NutsType TempObj = NutsTypeLogic.Instancia.SelectByID(Convert.ToInt32(txtIDNutsType.Text));

            if (TempObj.IDNutsType > 0)
            {
                if (checkActives.Checked)
                {
                    string Mensaje = string.Format("Do you wish to proceed with the deactivation of the ID Nut Type: {0}?", txtIDNutsType.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyNutsType = new NutsType
                        {
                            IDNutsType = Convert.ToInt32(txtIDNutsType.Text),
                            Active = 0
                        };

                        if (NutsTypeLogic.Instancia.Disable_Enable(MyNutsType))
                        {
                            MessageBox.Show("Nut Type successfully deactivated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowNutsTypes(checkActives.Checked);
                        }
                    }

                }
                else
                {
                    string Mensaje = string.Format("Do you wish to proceed with the activation of the ID Nut Type: {0}?", txtIDNutsType.Text);

                    DialogResult Continuar = MessageBox.Show(Mensaje, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        MyNutsType = new NutsType
                        {
                            IDNutsType = Convert.ToInt32(txtIDNutsType.Text),
                            Active = 1
                        };

                        if (NutsTypeLogic.Instancia.Disable_Enable(MyNutsType))
                        {
                            MessageBox.Show("Nut Type successfully activated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanForm();
                            ShowNutsTypes(checkActives.Checked);
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
            ShowNutsTypes(checkActives.Checked);

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
            txtIDNutsType.Clear();
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

        private void ShowNutsTypes(bool SeeActives, string RFilter = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(RFilter) &&
                RFilter != "Search...")
            {
                Filtro = RFilter;
            }

            dgvNutsTypes.DataSource = NutsTypeLogic.Instancia.Listar(checkActives.Checked, Filtro);

            dgvNutsTypes.ClearSelection();
        }
    }
}
