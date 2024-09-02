using Logica.Logic;
using Logica.Models;
using System;
using System.Windows.Forms;

namespace _0510Project.Forms
{
    public partial class FrmTestTable : Form
    {
        public FrmTestTable()
        {
            InitializeComponent();
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
                limpiar();
                mostrar_Test();
            }
        }


        public void mostrar_Test()
        {
            dgvTest.DataSource = null;
            dgvTest.DataSource = TestLogic.Instancia.Listar();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            mostrar_Test();
        }

        public void limpiar()
        {
            txtID.Text = "";
            txtPrueba.Text = "";
            txtPrueba.Focus();
        
        }


        private void FrmTestTable_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Test objeto = new Test()
            {
                ID = int.Parse(txtID.Text),
                Prueba = txtPrueba.Text
            };

            bool respuesta = TestLogic.Instancia.Editar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_Test();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Test objeto = new Test()
            {
                ID = int.Parse(txtID.Text),
            };

            bool respuesta = TestLogic.Instancia.Eliminar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_Test();
            }
        }
    }
}
