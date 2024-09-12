using Logica.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logic
{
    public class Screw_ToolLogic
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static Screw_ToolLogic _instancia = null;

        public Screw_ToolLogic()
        {

        }

        public static Screw_ToolLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Screw_ToolLogic();
                }
                return _instancia;
            }
        }

        public bool SaveScrew_Tool(Screw_Tool obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Insert into Screw_Tool (IDScrewTool, IDScrew) values (@IDScrewTool, @IDScrew)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDScrewTool", obj.IDScrewTool));
                cmd.Parameters.Add(new SQLiteParameter("@IDScrew", obj.IDScrew));

                cmd.CommandType = CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool DeleteScrew_Tool(Screw_Tool obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "DELETE FROM Screw_Tool WHERE IDScrewTool = @IDScrewTool AND IDScrew = @IDScrew";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDScrewTool", obj.IDScrewTool));
                cmd.Parameters.Add(new SQLiteParameter("@IDScrew", obj.IDScrew));

                cmd.CommandType = CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }



    }
}
