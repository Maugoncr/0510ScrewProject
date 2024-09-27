using Logica.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logica.Logic
{
    public class NutsLogic
    {

        private static string cadena = DatabaseConnection.GetConnectionString();

        private static NutsLogic _instancia = null;

        public NutsLogic()
        {

        }

        public static NutsLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new NutsLogic();
                }
                return _instancia;
            }
        }

        public bool Disable_Enable(Nuts obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update Nuts set Active = @Active WHERE IDNuts = @ID";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDNuts));
                cmd.Parameters.Add(new SQLiteParameter("@Active", obj.Active));
                cmd.CommandType = CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public DataTable Listar(bool VerActivos, string Filter)
        {
            DataTable R = new DataTable();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "SELECT * FROM View_NutsList WHERE Active = @Active ORDER BY IDNuts ASC";

                if (Filter != null && Filter != "")
                {
                    query = "SELECT * FROM View_NutsList WHERE Active = @Active AND NutsTypeName LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND NutsSizeName LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND SSNEPartNumber LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND VendorPartNumber LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND IDNuts LIKE '%' || @Filter || '%' ORDER BY IDNuts ASC";
                }

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@Active", VerActivos));

                if (Filter != null || Filter != "")
                {
                    cmd.Parameters.Add(new SQLiteParameter("@Filter", Filter));
                }

                cmd.CommandType = CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    R.Load(dr);
                    R.Columns.RemoveAt(3);
                }
            }
            return R;
        }


        public Nuts SelectScrewByID(int ID)
        {
            Nuts R = new Nuts();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM View_NutsSelectedByID WHERE IDNuts = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDNuts = Convert.ToInt32(dr["IDNuts"].ToString());
                        R.SSNEPartNumber = dr["SSNEPartNumber"].ToString();
                        R.VendorPartNumber = dr["VendorPartNumber"].ToString();
                        R.UrlPDF = dr["UrlPDF"].ToString();
                        R.UrlSTEP = dr["UrlSTEP"].ToString();

                        // Propiedades de Navegación

                        R.MyNutType.IDNutsType = Convert.ToInt32(dr["IDNutsType"].ToString());
                        R.MyNutType.NutsTypeName = dr["NutsTypeName"].ToString();

                        R.MyNutSize.IDNutsSize = Convert.ToInt32(dr["IDNutsSize"].ToString());
                        R.MyNutSize.NutsSizeName = dr["NutsSizeName"].ToString();
                    }
                }
            }
            return R;
        }

        public Nuts SelectScrewBySize(string SizeName, string TypeName)
        {
            Nuts R = new Nuts();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM View_NutsSelectedBySize WHERE Active = 1 AND NutsTypeName = @NutsTypeName AND NutsSizeName = @NutsSizeName", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@NutsTypeName", TypeName));
                cmd.Parameters.Add(new SQLiteParameter("@NutsSizeName", SizeName));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDNuts = Convert.ToInt32(dr["IDNuts"].ToString());
                        R.SSNEPartNumber = dr["SSNEPartNumber"].ToString();
                        R.VendorPartNumber = dr["VendorPartNumber"].ToString();
                        R.UrlPDF = dr["UrlPDF"].ToString();
                        R.UrlSTEP = dr["UrlSTEP"].ToString();

                        // Propiedades de Navegación

                        R.MyNutType.IDNutsType = Convert.ToInt32(dr["IDNutsType"].ToString());
                        R.MyNutType.NutsTypeName = dr["NutsTypeName"].ToString();

                        R.MyNutSize.IDNutsSize = Convert.ToInt32(dr["IDNutsSize"].ToString());
                        R.MyNutSize.NutsSizeName = dr["NutsSizeName"].ToString();
                    }
                }
            }
            return R;
        }

        public bool Guardar(Nuts obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into Nuts (IDNutsSize, IDNutsType, SSNEPartNumber, VendorPartNumber, UrlPDF, UrlSTEP) " +
                    "values (@IDNutsSize, @IDNutsType, @SSNEPartNumber, @VendorPartNumber, @UrlPDF, @UrlSTEP)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDNutsSize", obj.MyNutSize.IDNutsSize));
                cmd.Parameters.Add(new SQLiteParameter("@IDNutsType", obj.MyNutType.IDNutsType));
                cmd.Parameters.Add(new SQLiteParameter("@SSNEPartNumber", obj.SSNEPartNumber));
                cmd.Parameters.Add(new SQLiteParameter("@VendorPartNumber", obj.VendorPartNumber));
                cmd.Parameters.Add(new SQLiteParameter("@UrlPDF", obj.UrlPDF));
                cmd.Parameters.Add(new SQLiteParameter("@UrlSTEP", obj.UrlSTEP));

                cmd.CommandType = CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }


        public bool Editar(Nuts obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update Nuts set IDNutsType = @IDNutsType, IDNutsSize = @IDNutsSize, " +
                    "SSNEPartNumber = @SSNEPartNumber, VendorPartNumber = @VendorPartNumber, " +
                    "UrlPDF = @UrlPDF, UrlSTEP = @UrlSTEP WHERE IDNuts = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDNutsType", obj.MyNutType.IDNutsType));
                cmd.Parameters.Add(new SQLiteParameter("@IDNutsSize", obj.MyNutSize.IDNutsSize));
                cmd.Parameters.Add(new SQLiteParameter("@SSNEPartNumber", obj.SSNEPartNumber));
                cmd.Parameters.Add(new SQLiteParameter("@VendorPartNumber", obj.VendorPartNumber));
                cmd.Parameters.Add(new SQLiteParameter("@UrlPDF", obj.UrlPDF));
                cmd.Parameters.Add(new SQLiteParameter("@UrlSTEP", obj.UrlSTEP));

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDNuts));
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
