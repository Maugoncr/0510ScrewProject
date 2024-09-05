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
    public class ScrewAbbreviationLogic
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ScrewAbbreviationLogic _instancia = null;

        public ScrewAbbreviationLogic()
        {

        }

        public static ScrewAbbreviationLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ScrewAbbreviationLogic();
                }
                return _instancia;
            }
        }


        public bool Guardar(ScrewAbbreviation obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into ScrewAbbreviation (AbbreviationName) values (@AbbreviationName)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@AbbreviationName", obj.AbbreviationName));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<ScrewAbbreviation> Listar(bool VerActivos, string Filter)
        {
            List<ScrewAbbreviation> oLista = new List<ScrewAbbreviation>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDScrewAbbreviation, AbbreviationName FROM ScrewAbbreviation WHERE Active = @Active ORDER BY IDScrewAbbreviation ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDScrewAbbreviation, AbbreviationName FROM ScrewAbbreviation WHERE Active = @Active AND AbbreviationName LIKE '%' || @Filter || '%' ORDER BY IDScrewAbbreviation ASC";
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
                        oLista.Add(new ScrewAbbreviation()
                        {
                            IDScrewAbbreviation = int.Parse(dr["IDScrewAbbreviation"].ToString()),
                            AbbreviationName = dr["AbbreviationName"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }

        public ScrewAbbreviation SelectByID(int ID)
        {
            ScrewAbbreviation R = new ScrewAbbreviation();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDScrewAbbreviation, AbbreviationName FROM ScrewAbbreviation WHERE IDScrewAbbreviation = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDScrewAbbreviation = Convert.ToInt32(dr["IDScrewAbbreviation"].ToString());
                        R.AbbreviationName = dr["AbbreviationName"].ToString();
                    }
                }
            }
            return R;
        }


        public bool Editar(ScrewAbbreviation obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewAbbreviation set AbbreviationName = @AbbreviationName WHERE IDScrewAbbreviation = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@AbbreviationName", obj.AbbreviationName));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewAbbreviation));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(ScrewAbbreviation obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewAbbreviation set Active = @Active WHERE IDScrewAbbreviation = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewAbbreviation));
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
