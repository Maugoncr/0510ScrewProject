using Logica.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logic
{
    public class ScrewNToolLogic
    {

        private static string cadena = DatabaseConnection.GetConnectionString();

        private static ScrewNToolLogic _instancia = null;

        public ScrewNToolLogic()
        {

        }

        public static ScrewNToolLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ScrewNToolLogic();
                }
                return _instancia;
            }
        }


        public bool Guardar(ScrewNTool obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into ScrewNTool (NToolName) values (@NToolName)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@NToolName", obj.NToolName));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<ScrewNTool> Listar(bool VerActivos, string Filter)
        {
            List<ScrewNTool> oLista = new List<ScrewNTool>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDScrewNTool, NToolName FROM ScrewNTool WHERE Active = @Active ORDER BY IDScrewNTool ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDScrewNTool, NToolName FROM ScrewNTool WHERE Active = @Active AND NToolName LIKE '%' || @Filter || '%' ORDER BY IDScrewNTool ASC";
                }

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@Active", VerActivos));

                if (Filter != null || Filter != "")
                {
                    cmd.Parameters.Add(new SQLiteParameter("@Filter", Filter));
                }

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new ScrewNTool()
                        {
                            IDScrewNTool = int.Parse(dr["IDScrewNTool"].ToString()),
                            NToolName = dr["NToolName"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }

        public ScrewNTool SelectByID(int ID)
        {
            ScrewNTool R = new ScrewNTool();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDScrewNTool, NToolName FROM ScrewNTool WHERE IDScrewNTool = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDScrewNTool = Convert.ToInt32(dr["IDScrewNTool"].ToString());
                        R.NToolName = dr["NToolName"].ToString();
                    }
                }
            }
            return R;
        }


        public bool Editar(ScrewNTool obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewNTool set NToolName = @NToolName WHERE IDScrewNTool = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@NToolName", obj.NToolName));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewNTool));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(ScrewNTool obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewNTool set Active = @Active WHERE IDScrewNTool = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewNTool));
                cmd.Parameters.Add(new SQLiteParameter("@Active", obj.Active));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }
    }
}
