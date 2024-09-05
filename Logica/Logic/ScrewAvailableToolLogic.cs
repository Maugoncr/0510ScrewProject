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
    public class ScrewAvailableToolLogic
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ScrewAvailableToolLogic _instancia = null;

        public ScrewAvailableToolLogic()
        {

        }

        public static ScrewAvailableToolLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ScrewAvailableToolLogic();
                }
                return _instancia;
            }
        }


        public bool Guardar(ScrewAvailableTool obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into ScrewAvailableTool (ToolName) values (@ToolName)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ToolName", obj.ToolName));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<ScrewAvailableTool> Listar(bool VerActivos, string Filter)
        {
            List<ScrewAvailableTool> oLista = new List<ScrewAvailableTool>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDScrewTool, ToolName FROM ScrewAvailableTool WHERE Active = @Active ORDER BY IDScrewTool ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDScrewTool, ToolName FROM ScrewAvailableTool WHERE Active = @Active AND ToolName LIKE '%' || @Filter || '%' ORDER BY IDScrewTool ASC";
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
                        oLista.Add(new ScrewAvailableTool()
                        {
                            IDScrewTool = int.Parse(dr["IDScrewTool"].ToString()),
                            ToolName = dr["ToolName"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }

        public ScrewAvailableTool SelectByID(int ID)
        {
            ScrewAvailableTool R = new ScrewAvailableTool();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDScrewTool, ToolName FROM ScrewAvailableTool WHERE IDScrewTool = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDScrewTool = Convert.ToInt32(dr["IDScrewTool"].ToString());
                        R.ToolName = dr["ToolName"].ToString();
                    }
                }
            }
            return R;
        }


        public bool Editar(ScrewAvailableTool obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewAvailableTool set ToolName = @ToolName WHERE IDScrewTool = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ToolName", obj.ToolName));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewTool));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(ScrewAvailableTool obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewAvailableTool set Active = @Active WHERE IDScrewTool = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewTool));
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
