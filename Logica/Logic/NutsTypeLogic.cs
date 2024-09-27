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
    public class NutsTypeLogic
    {
        private static string cadena = DatabaseConnection.GetConnectionString();

        private static NutsTypeLogic _instancia = null;

        public NutsTypeLogic()
        {

        }

        public static NutsTypeLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new NutsTypeLogic();
                }
                return _instancia;
            }
        }

        public bool Guardar(NutsType obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into NutsType (NutsTypeName) values (@NutsTypeName)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@NutsTypeName", obj.NutsTypeName));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<NutsType> Listar(bool VerActivos, string Filter)
        {
            List<NutsType> oLista = new List<NutsType>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDNutsType, NutsTypeName FROM NutsType WHERE Active = @Active ORDER BY IDNutsType ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDNutsType, NutsTypeName FROM NutsType WHERE Active = @Active AND NutsTypeName LIKE '%' || @Filter || '%' ORDER BY IDNutsType ASC";
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
                        oLista.Add(new NutsType()
                        {
                            IDNutsType = int.Parse(dr["IDNutsType"].ToString()),
                            NutsTypeName = dr["NutsTypeName"].ToString()
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

                string query = "Select IDNutsType, NutsTypeName FROM NutsType WHERE Active = 1 ORDER BY IDNutsType ASC";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    R.Load(dr);
                }
            }
            return R;
        }

        public NutsType SelectByID(int ID)
        {
            NutsType R = new NutsType();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDNutsType, NutsTypeName FROM NutsType WHERE IDNutsType = @ID", conn))
            { 
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDNutsType = Convert.ToInt32(dr["IDNutsType"].ToString());
                        R.NutsTypeName = dr["NutsTypeName"].ToString();
                    }
                }
            }

            return R;
        }


        public bool Editar(NutsType obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update NutsType set NutsTypeName = @NutsTypeName WHERE IDNutsType = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@NutsTypeName", obj.NutsTypeName));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDNutsType));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(NutsType obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update NutsType set Active = @Active WHERE IDNutsType = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDNutsType));
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
