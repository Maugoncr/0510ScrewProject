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
    public class WasherSizeLogic
    {
        private static string cadena = DatabaseConnection.GetConnectionString();

        private static WasherSizeLogic _instancia = null;

        public WasherSizeLogic()
        {

        }

        public static WasherSizeLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new WasherSizeLogic();
                }
                return _instancia;
            }
        }


        public bool Guardar(WasherSize obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into WasherSize (WasherSizeName) values (@WasherSizeName)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@WasherSizeName", obj.WasherSizeName));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<WasherSize> Listar(bool VerActivos, string Filter)
        {
            List<WasherSize> oLista = new List<WasherSize>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDWasherSize, WasherSizeName FROM WasherSize WHERE Active = @Active ORDER BY IDWasherSize ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDWasherSize, WasherSizeName FROM WasherSize WHERE Active = @Active AND WasherSizeName LIKE '%' || @Filter || '%' ORDER BY IDWasherSize ASC";
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
                        oLista.Add(new WasherSize()
                        {
                            IDWasherSize = int.Parse(dr["IDWasherSize"].ToString()),
                            WasherSizeName = dr["WasherSizeName"].ToString()
                        });
                    }
                }
            }

            return oLista;
        }

        public WasherSize SelectByID(int ID)
        {
            WasherSize R = new WasherSize();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDWasherSize, WasherSizeName FROM WasherSize WHERE IDWasherSize = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDWasherSize = Convert.ToInt32(dr["IDWasherSize"].ToString());
                        R.WasherSizeName = dr["WasherSizeName"].ToString();
                    }
                }
            }

            return R;
        }

        public WasherSize SelectByName(string SizeName)
        {
            WasherSize R = new WasherSize();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDWasherSize FROM WasherSize WHERE WasherSizeName = @WasherSizeName AND Active = 1", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@WasherSizeName", SizeName));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDWasherSize = Convert.ToInt32(dr["IDWasherSize"].ToString());
                    }
                }
            }

            return R;
        }


        public bool Editar(WasherSize obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update WasherSize set WasherSizeName = @WasherSizeName WHERE IDWasherSize = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@WasherSizeName", obj.WasherSizeName));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDWasherSize));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(WasherSize obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update WasherSize set Active = @Active WHERE IDWasherSize = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDWasherSize));
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
