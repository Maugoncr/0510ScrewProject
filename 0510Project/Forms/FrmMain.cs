using _0510Project.Forms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Control = System.Windows.Forms.Control;
using Label = System.Windows.Forms.Label;
using Logica.Models;
using Logica.Logic;

namespace _0510Project
{
    public partial class FrmMain : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmMain()
        {
            InitializeComponent();

            InitializeLabelEvents();
        }

        private void tDateTime_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFormSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ResetAppereance();

            LoadDataGridView();
            ConfigureDataGridView();
        }

        private void ResetAppereance()
        {
            lbDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            btnExit.IconChar = IconChar.ArrowRightFromBracket;

           // picISOView.Image = Properties.Resources.PlaceHolderImage;
           // picTopView.Image = Properties.Resources.PlaceHolderImage;
            picLength.Image = null;

            lbAbbreviation.Text = "---";
            lbMaterial.Text = "---";
            lbNToolc.Text = "---";

            pSizeSelect.Enabled = false;
            pLengths.Enabled = false;

            btnPDF.Enabled = false;
            btnSTP.Enabled = false;

            foreach (Control control in pSizeSelect.Controls)
            {
                if (control is Label && control.Name.StartsWith("s"))
                {
                    control.BackColor = Color.White;
                }
            }


        }

        private void LoadDataGridView()
        {
          
                // Primero, asegúrate de que tu DataGridView está configurado con las columnas necesarias.
                dgvLength.Columns.Clear();
                dgvLength.Columns.Add("Measurement", "Measurement");
                dgvLength.Columns.Add("1", "1");
                dgvLength.Columns.Add("2", "2");
                dgvLength.Columns.Add("3", "3");
                dgvLength.Columns.Add("4", "4");
                dgvLength.Columns.Add("5", "5");
                dgvLength.Columns.Add("6", "6");
                dgvLength.Columns.Add("7", "7");
                dgvLength.Columns.Add("8", "8");
                dgvLength.Columns.Add("9", "9");
                dgvLength.Columns.Add("10", "10");
                dgvLength.Columns.Add("11", "11");
                dgvLength.Columns.Add("12", "12");
                dgvLength.Columns.Add("13", "13");
                dgvLength.Columns.Add("14", "14");
                dgvLength.Columns.Add("15", "15");
                dgvLength.Columns.Add("16", "16");
                

            // Suponiendo que 'dataGridView1' ya tiene las columnas configuradas correctamente.
            string[,] data = new string[,]
            {
        {"Inches", "1/8\"", "1/4\"", "3/8\"", "1/2\"", "5/8\"", "3/4\"", "7/8\"", "1\"", "1 1/8\"", "1 1/4\"", "1 3/8\"", "1 1/2\"", "1 5/8\"", "1 3/4\"", "1 7/8\"", "2\""},
        {"Decimal", "0.125\"", "0.250\"", "0.375\"", "0.500\"", "0.625\"", "0.750\"", "0.875\"", "1.000\"", "1.125\"", "1.250\"", "1.375\"", "1.500\"", "1.625\"", "1.750\"", "1.875\"", "2.000\""},
        {"Metric", "3.175 mm", "6.35 mm", "9.525 mm", "12.7 mm", "15.875 mm", "19.05 mm", "22.225 mm", "25.4 mm", "28.575 mm", "31.75 mm", "34.925 mm", "38.1 mm", "41.275 mm", "44.45 mm", "47.625 mm", "50.8 mm"}
        
            };

            // Añadir las filas al DataGridView
            for (int i = 0; i < data.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvLength);  // Crear las celdas para la fila basadas en la configuración de DataGridView

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    row.Cells[j].Value = data[i, j];  // '+1' porque la primera celda (j=0) se dejará para el encabezado de fila si se usa
                }

                dgvLength.Rows.Add(row);
            }

            foreach (DataGridViewColumn column in dgvLength.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvLength.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvLength.MultiSelect = false;
        }

        private void ConfigureDataGridView()
        {
            foreach (DataGridViewRow row in dgvLength.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }

            foreach (DataGridViewColumn column in dgvLength.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }



            foreach (DataGridViewColumn column in dgvLength.Columns)
            {
                column.Width = 110; // Establece el ancho de todas las columnas a 100 píxeles
            }

            foreach (DataGridViewRow row in dgvLength.Rows)
            {
                row.Height = 50; // Establece el alto de todas las filas a 30 píxeles
            }

            // Configuración de la primera columna para usar el espacio restante
            dgvLength.Columns["Measurement"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLength.ColumnHeadersVisible = false;



            // Cambiar la fuente y tamaño para todas las celdas
            dgvLength.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            // Centrar el texto en todas las celdas y encabezados
            dgvLength.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLength.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLength.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dgvLength.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Asegúrate de que el DataGridView no muestra la cabecera de filas si aún no lo has configurado
            dgvLength.RowHeadersVisible = false;
        }

      

      

        private void cbDriveType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDriveType.SelectedItem.ToString() == "Socket Head Screw")
            {
                picISOView.Visible = true;
               // picISOView.Image = Properties.Resources.Socket;

                picTopView.Visible = true;
               // picTopView.Image = Properties.Resources.SocketTop;

                lbAbbreviation.Text = "SOC HD";

                lbMaterial.Text = "SST";

                lbNToolc.Text = "--- Number";

               // picLength.Image = Properties.Resources.LengthSocketHead;
            }

            if (cbDriveType.SelectedItem.ToString() == "Countersunk Screw")
            {
                picISOView.Visible = true;
              //  picISOView.Image = Properties.Resources.SunkISO;

                picTopView.Visible = true;
              //  picTopView.Image = Properties.Resources.SunkTop;

                lbAbbreviation.Text = "CS";

                lbMaterial.Text = "SST";

                lbNToolc.Text = "N° ---";

               // picLength.Image = Properties.Resources.LengthSunk;
            }

            if (cbDriveType.SelectedItem.ToString() == "Torx Screw")
            {
                picISOView.Visible = true;
//picISOView.Image = Properties.Resources.TorxISO;

                picTopView.Visible = true;
              //  picTopView.Image = Properties.Resources.TorxTop;

                lbAbbreviation.Text = "T";

                lbMaterial.Text = "SST";

                lbNToolc.Text = "N° ---";

              //  picLength.Image = Properties.Resources.LengthTorx;
            }

            if (cbDriveType.SelectedItem.ToString() == "Vent Socket Head Screw")
            {
                picISOView.Visible = true;
              //  picISOView.Image = Properties.Resources.VentISO;

                picTopView.Visible = true;
              //  picTopView.Image = Properties.Resources.VentTop;

                lbAbbreviation.Text = "V SOC HD";

                lbMaterial.Text = "SST";

                lbNToolc.Text = "N° ---";

//picLength.Image = Properties.Resources.LengthVent;
            }

            pSizeSelect.Enabled = true;

        }

        private void txtSearchSize_TextChanged(object sender, EventArgs e)
        {
            // Supongamos que tienes una lista original de elementos
            List<string> allItems = new List<string>() { "0-80", "1-64", "1-72", "2-56", "2-64", "3-48", "3-56", "4-40" };

            // Filtrar los elementos en base al texto ingresado
            var filteredItems = allItems.Where(item => item.Contains(txtSearchSize.Text)).ToList();

            // Actualizar los ítems del ListBox
            listSize.DataSource = filteredItems;
        }

        private void txtSearchLength_TextChanged(object sender, EventArgs e)
        {
            // Supongamos que tienes una lista original de elementos
            List<string> allItems = new List<string>() {
                "X",
                "1/4\"",
                "3/8\"",
                "1/2\"",
                "5/8\"",
                "3/4\"",
                "7/8\"",
                "1\"",
                "1\" X",
                "1\" 1/4",
                "1\" 3/8",
                "1\" 1/2",
                "1\" 5/8",
                "1\" 3/4"
            };

            // Filtrar los elementos en base al texto ingresado
            var filteredItems = allItems.Where(item => item.Contains(txtSearchLength.Text)).ToList();

            // Actualizar los ítems del ListBox
            listLength.DataSource = filteredItems;
        }

        private void txtSearchSize_Click(object sender, EventArgs e)
        {
            txtSearchSize.SelectAll();
        }

        private void txtSearchLength_Click(object sender, EventArgs e)
        {
            txtSearchLength.SelectAll();
        }

        private void listLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLength.SelectedItem.ToString() == "1/4\"")
            {
               

            }
        }

        

        private void btnSTP_Click(object sender, EventArgs e)
        {
           
                // Crear una instancia de SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                // Establecer el filtro para el tipo de archivo (opcional)
                saveFileDialog.Filter = "All Files (*.*)|*.*";

                // Establecer el nombre predeterminado del archivo (opcional)
                saveFileDialog.FileName = "200-21165.STEP";

                // Mostrar el cuadro de diálogo y comprobar si el usuario hizo clic en "Guardar"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta seleccionada por el usuario
                    string destino = saveFileDialog.FileName;

                    // Ruta del archivo original
                    string rutaOrigen = "C:\\Users\\maugo\\source\\repos\\0510Project\\0510Project\\FilesPDF\\200-21165.STEP";

                    try
                    {
                        // Copiar el archivo a la ubicación seleccionada
                        System.IO.File.Copy(rutaOrigen, destino, true);

                        // Mensaje de confirmación
                        MessageBox.Show("File Saved in: " + destino, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                    }
                
                }

        }

        // Manera rapida de asociar controles al evento click que necesitamos para realizar la funcionalidad de selección
        private void InitializeLabelEvents()
        {
            for (int i = 1; i <= 16; i++)
            {
                var label = pLengths.Controls.Find($"c{i}", true).FirstOrDefault() as Label;
                if (label != null) label.Click += SelectColumnLength;

                var labelA = pLengths.Controls.Find($"c{i}a", true).FirstOrDefault() as Label;
                if (labelA != null) labelA.Click += SelectColumnLength;

                var labelB = pLengths.Controls.Find($"c{i}b", true).FirstOrDefault() as Label;
                if (labelB != null) labelB.Click += SelectColumnLength;
            }

            for (int i = 0; i <= 10; i++)
            {
                var label = pSizeSelect.Controls.Find($"s{i}", true).FirstOrDefault() as Label;
                if (label != null) label.Click += SelectColumnSize;
            }
        }

        // Función que recibe un control label, este se pinta de amarillo y posteriormente se pintan de blanco todos los demás controles label para mostrar un
        // esencia de estar seleccionando labels
        private void SelectColumnSize(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                clickedLabel.BackColor = Color.Yellow;

                pLengths.Enabled = true;

                foreach (Control control in pSizeSelect.Controls)
                {
                    if (control is Label && control.Name.Contains("s") && control.Name != clickedLabel.Name)
                    {
                        control.BackColor = Color.White;
                    }
                }
            }
        }

        private void SelectColumnLength(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                string input = clickedLabel.Name.Trim('a', 'b');

                PaintSelectedColumn(input);
                DeselectOtherLength(input);

                btnPDF.Enabled = true;
                btnSTP.Enabled = true;
            }
        }

        private void PaintSelectedColumn(string inputColumn)
        {
            foreach ( Control control in pLengths.Controls)
            {
                if (control is Label && (control.Name == inputColumn || control.Name == $"{inputColumn}a" || control.Name == $"{inputColumn}b"))
                {
                    control.BackColor = Color.Yellow;
                }
            }
        }

        private void DeselectOtherLength(string baseName)
        {
            string result = baseName.Replace("c", "");

            foreach (Control control in pLengths.Controls)
            {
                if (control is Label && control.Name.StartsWith("c") && !(control.Name == $"c{result}" || control.Name == $"c{result}a" || control.Name == $"c{result}b"))
                {
                    control.BackColor = Color.White;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAppereance();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            FrmViewPDF frmScale = new FrmViewPDF("https://drive.google.com/file/d/14ZVIqs6Lp-E-Qg7wtM1tgMs1xVekFcEn/view?usp=drive_link");
            frmScale.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Test objeto = new Test()
            { 
                Prueba = txtPrueba.Text
            };

            bool respuesta = TestLogic.Instancia.Guardar(objeto);

            if (respuesta)
            {
                mostrar_Test();
            }
        }


        public void mostrar_Test()
        {
            dgvTest.DataSource = null;
            dgvTest.DataSource = TestLogic.Instancia.Listar();
        }

    }
}
