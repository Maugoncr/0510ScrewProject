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
    public class WasherTypeLogic
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static WasherTypeLogic _instancia = null;

        public WasherTypeLogic()
        {

        }

        public static WasherTypeLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new WasherTypeLogic();
                }
                return _instancia;
            }
        }

        public bool Guardar(WasherType obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into WasherType(WasherTypeName) values (@WasherTypeName)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@WasherTypeName", obj.WasherTypeName));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<WasherType> Listar(bool VerActivos, string Filter)
        {
            List<WasherType> oLista = new List<WasherType>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDWasherType, WasherTypeName FROM WasherType WHERE Active = @Active ORDER BY IDWasherType ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDWasherType, WasherTypeName FROM WasherType WHERE Active = @Active AND WasherTypeName LIKE '%' || @Filter || '%' ORDER BY IDWasherType ASC";
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
                        oLista.Add(new WasherType()
                        {
                            IDWasherType = int.Parse(dr["IDWasherType"].ToString()),
                            WasherTypeName = dr["WasherTypeName"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }


        public DataTable ListarCombo()
        {
            DataTable R = new DataTable();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDWasherType, WasherTypeName FROM WasherType WHERE Active = 1 ORDER BY IDWasherType ASC";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    R.Load(dr);
                }
            }
            return R;
        }

        public WasherType SelectByID(int ID)
        {
            WasherType R = new WasherType();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDWasherType, WasherTypeName FROM WasherType WHERE IDWasherType = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDWasherType = Convert.ToInt32(dr["IDWasherType"].ToString());
                        R.WasherTypeName = dr["WasherTypeName"].ToString();
                    }
                }
            }

            return R;
        }


        public bool Editar(WasherType obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update WasherType set WasherTypeName = @WasherTypeName WHERE IDWasherType = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@WasherTypeName", obj.WasherTypeName));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDWasherType));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(WasherType obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update WasherType set Active = @Active WHERE IDWasherType = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDWasherType));
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
