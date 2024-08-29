using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Logica.Models;
using System.Data.SQLite;

namespace Logica.Logic
{
    public class TestLogic
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static TestLogic _instancia = null;

        public TestLogic()
        {

        }

        public static TestLogic Instancia 
        {  
            get {
                if (_instancia == null)
                {
                    _instancia = new TestLogic();
                }
                return _instancia; 
            } 
        }

        public bool Guardar(Test obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into Test(Prueba) values (@Prueba)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@Prueba", obj.Prueba));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<Test> Listar()
        { 
            List<Test> oLista = new List<Test>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select ID, Prueba from Test";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
               
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Test()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Prueba = dr["Prueba"].ToString(),
                        });
                    }
                }
            }

            return oLista;
        }

    }
}
