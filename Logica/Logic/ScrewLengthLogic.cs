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
    public class ScrewLengthLogic
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ScrewLengthLogic _instancia = null;

        public ScrewLengthLogic()
        {

        }

        public static ScrewLengthLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ScrewLengthLogic();
                }
                return _instancia;
            }
        }


        public bool Guardar(ScrewLength obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into ScrewLength (LengthInch, LengthDecimal, LengthMetric) values (@LengthInch, @LengthDecimal, @LengthMetric)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@LengthInch", obj.LengthInch));
                cmd.Parameters.Add(new SQLiteParameter("@LengthDecimal", obj.LengthDecimal));
                cmd.Parameters.Add(new SQLiteParameter("@LengthMetric", obj.LengthMetric));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<ScrewLength> Listar(bool VerActivos, string Filter)
        {
            List<ScrewLength> oLista = new List<ScrewLength>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Select IDScrewLength, LengthInch, LengthDecimal, LengthMetric FROM ScrewLength WHERE Active = @Active ORDER BY IDScrewLength ASC";

                if (Filter != null && Filter != "")
                {
                    query = "Select IDScrewLength, LengthInch, LengthDecimal, LengthMetric FROM ScrewLength WHERE Active = @Active AND LengthInch LIKE '%' || @Filter || '%' OR Active = @Active AND LengthDecimal LIKE '%' || @Filter || '%' OR Active = @Active AND LengthMetric LIKE '%' || @Filter || '%' ORDER BY IDScrewLength ASC";
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
                        oLista.Add(new ScrewLength()
                        {
                            IDScrewLength = int.Parse(dr["IDScrewLength"].ToString()),
                            LengthInch = dr["LengthInch"].ToString(),
                            LengthDecimal = dr["LengthDecimal"].ToString(),
                            LengthMetric = dr["LengthMetric"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }

        public ScrewLength SelectByID(int ID)
        {
            ScrewLength R = new ScrewLength();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDScrewLength, LengthInch, LengthDecimal, LengthMetric FROM ScrewLength WHERE IDScrewLength = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDScrewLength = Convert.ToInt32(dr["IDScrewLength"].ToString());
                        R.LengthInch = dr["LengthInch"].ToString();
                        R.LengthDecimal = dr["LengthDecimal"].ToString();
                        R.LengthMetric = dr["LengthMetric"].ToString();
                    }
                }
            }
            return R;
        }


        public bool Editar(ScrewLength obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewLength set LengthInch = @LengthInch, LengthDecimal = @LengthDecimal, LengthMetric = @LengthMetric " +
                    "WHERE IDScrewLength = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@LengthInch", obj.LengthInch));
                cmd.Parameters.Add(new SQLiteParameter("@LengthDecimal", obj.LengthDecimal));
                cmd.Parameters.Add(new SQLiteParameter("@LengthMetric", obj.LengthMetric));
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewLength));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Disable_Enable(ScrewLength obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update ScrewLength set Active = @Active WHERE IDScrewLength = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewLength));
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
