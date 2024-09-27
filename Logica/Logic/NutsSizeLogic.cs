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
    public class NutsSizeLogic
    {
        private static string cadena = DatabaseConnection.GetConnectionString();

        private static NutsSizeLogic _instancia = null;

        public NutsSizeLogic()
        {

        }

        public static NutsSizeLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new NutsSizeLogic();
                }
                return _instancia;
            }
        }


        public bool Guardar(NutsSize obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into NutsSize (NutsSizeName) values (@NutsSizeName)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@NutsSizeName", obj.NutsSizeName));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<NutsSize> Listar(bool VerActivos, string Filter)
        {
            List<NutsSize> oLista = new List<NutsSize>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDNutsSize, NutsSizeName FROM NutsSize WHERE Active = @Active ORDER BY IDNutsSize ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDNutsSize, NutsSizeName FROM NutsSize WHERE Active = @Active AND NutsSizeName LIKE '%' || @Filter || '%' ORDER BY IDNutsSize ASC";
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
                        oLista.Add(new NutsSize()
                        {
                            IDNutsSize = int.Parse(dr["IDNutsSize"].ToString()),
                            NutsSizeName = dr["NutsSizeName"].ToString()
                        });
                    }
                }
            }

            return oLista;
        }

        public NutsSize SelectByID(int ID)
        {
            NutsSize R = new NutsSize();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDNutsSize, NutsSizeName FROM NutsSize WHERE IDNutsSize = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDNutsSize = Convert.ToInt32(dr["IDNutsSize"].ToString());
                        R.NutsSizeName = dr["NutsSizeName"].ToString();
                    }
                }
            }

            return R;
        }

        public NutsSize SelectByName(string SizeName)
        {
            NutsSize R = new NutsSize();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDNutsSize FROM NutsSize WHERE NutsSizeName = @NutsSizeName AND Active = 1", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@NutsSizeName", SizeName));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDNutsSize = Convert.ToInt32(dr["IDNutsSize"].ToString());
                    }
                }
            }

            return R;
        }


        public bool Editar(NutsSize obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update NutsSize set NutsSizeName = @NutsSizeName WHERE IDNutsSize = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@NutsSizeName", obj.NutsSizeName));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDNutsSize));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(NutsSize obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update NutsSize set Active = @Active WHERE IDNutsSize = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDNutsSize));
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
