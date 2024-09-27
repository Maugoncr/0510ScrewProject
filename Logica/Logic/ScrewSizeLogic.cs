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
    public class ScrewSizeLogic
    {
        private static string cadena = DatabaseConnection.GetConnectionString();

        private static ScrewSizeLogic _instancia = null;

        public ScrewSizeLogic()
        {

        }

        public static ScrewSizeLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ScrewSizeLogic();
                }
                return _instancia;
            }
        }


        public bool Guardar(ScrewSize obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into ScrewSize (SizeName) values (@SizeName)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@SizeName", obj.SizeName));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<ScrewSize> Listar(bool VerActivos, string Filter)
        {
            List<ScrewSize> oLista = new List<ScrewSize>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDScrewSize, SizeName FROM ScrewSize WHERE Active = @Active ORDER BY IDScrewSize ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDScrewSize, SizeName FROM ScrewSize WHERE Active = @Active AND SizeName LIKE '%' || @Filter || '%' ORDER BY IDScrewSize ASC";
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
                        oLista.Add(new ScrewSize()
                        {
                            IDScrewSize = int.Parse(dr["IDScrewSize"].ToString()),
                            SizeName = dr["SizeName"].ToString()
                        });
                    }
                }
            }

            return oLista;
        }

        public ScrewSize SelectByID(int ID)
        {
            ScrewSize R = new ScrewSize();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDScrewSize, SizeName FROM ScrewSize WHERE IDScrewSize = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDScrewSize = Convert.ToInt32(dr["IDScrewSize"].ToString());
                        R.SizeName = dr["SizeName"].ToString();
                    }
                }
            }

            return R;
        }

        public ScrewSize SelectByName(string SizeName)
        {
            ScrewSize R = new ScrewSize();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDScrewSize FROM ScrewSize WHERE SizeName = @SizeName AND Active = 1", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@SizeName", SizeName));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDScrewSize = Convert.ToInt32(dr["IDScrewSize"].ToString());
                    }
                }
            }

            return R;
        }


        public bool Editar(ScrewSize obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewSize set SizeName = @SizeName WHERE IDScrewSize = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@SizeName", obj.SizeName));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewSize));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(ScrewSize obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewSize set Active = @Active WHERE IDScrewSize = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewSize));
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
