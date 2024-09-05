using Logica.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace Logica.Logic
{
    public class ScrewTypeLogic
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ScrewTypeLogic _instancia = null;

        public ScrewTypeLogic()
        {

        }

        public static ScrewTypeLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ScrewTypeLogic();
                }
                return _instancia;
            }
        }

        public bool Guardar(ScrewType obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into ScrewType(TypeName) values (@TypeName)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@TypeName", obj.TypeName));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<ScrewType> Listar(bool VerActivos, string Filter)
        {
            List<ScrewType> oLista = new List<ScrewType>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDScrewType, TypeName FROM ScrewType WHERE Active = @Active ORDER BY IDScrewType ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDScrewType, TypeName FROM ScrewType WHERE Active = @Active AND TypeName LIKE '%' || @Filter || '%' ORDER BY IDScrewType ASC";
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
                        oLista.Add(new ScrewType()
                        {
                            IDScrewType = int.Parse(dr["IDScrewType"].ToString()),
                            TypeName = dr["TypeName"].ToString()
                        });
                    }
                }
            }

            return oLista;
        }

        public ScrewType SelectByID(int ID)
        { 
            ScrewType R = new ScrewType();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDScrewType, TypeName FROM ScrewType WHERE IDScrewType = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDScrewType = Convert.ToInt32(dr["IDScrewType"].ToString());
                        R.TypeName = dr["TypeName"].ToString();
                    }
                }
            }

            return R;
        }


        public bool Editar(ScrewType obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewType set TypeName = @TypeName WHERE IDScrewType = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@TypeName", obj.TypeName));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewType));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(ScrewType obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewType set Active = @Active WHERE IDScrewType = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewType));
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
