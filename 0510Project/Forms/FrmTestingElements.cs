using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0510Project.Forms
{
    public partial class FrmTestingElements : Form
    {
        public FrmTestingElements()
        {
            InitializeComponent();
        }

        private void FrmTestingElements_Load(object sender, EventArgs e)
        {
            // Configuración básica del DataGridView
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowTemplate.Height = 50; // Ajustar la altura de las celdas

            // Aplicar un estilo de celda para que se vean como botones
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cellStyle.BackColor = Color.White;
            cellStyle.ForeColor = Color.Black;
            cellStyle.SelectionBackColor = Color.LightGray; // Cambiar el color al seleccionar
            cellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle = cellStyle;

            // Agregar las columnas y filas necesarias
            dataGridView1.Columns.Add("Column1", ""); // Agregar columnas
            dataGridView1.Rows.Add(1); // Agregar una fila

            // Rellenar las celdas con los valores deseados
            dataGridView1.Rows[0].Cells[0].Value = "4 - 40";
            // Repite para las demás celdas...

            // Evento para manejar el clic en las celdas
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                    MessageBox.Show("Has seleccionado: " + value);
                }
        }
    }
}
