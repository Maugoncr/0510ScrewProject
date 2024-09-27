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
    public class WashersLogic
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static WashersLogic _instancia = null;

        public WashersLogic()
        {

        }

        public static WashersLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new WashersLogic();
                }
                return _instancia;
            }
        }

        public bool Disable_Enable(Washers obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update Washers set Active = @Active WHERE IDWasher = @ID";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDWasher));
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

                string query = "SELECT * FROM View_WasherList WHERE Active = @Active ORDER BY IDWasher ASC";

                if (Filter != null && Filter != "")
                {
                    query = "SELECT * FROM View_WasherList WHERE Active = @Active AND WasherTypeName LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND WasherSizeName LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND SSNEPartNumber LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND VendorPartNumber LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND IDWasher LIKE '%' || @Filter || '%' ORDER BY IDWasher ASC";
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
       

        public Washers SelectScrewByID(int ID)
        {
            Washers R = new Washers();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM View_WasherSelectedByID WHERE IDWasher = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDWasher = Convert.ToInt32(dr["IDWasher"].ToString());
                        R.SSNEPartNumber = dr["SSNEPartNumber"].ToString();
                        R.VendorPartNumber = dr["VendorPartNumber"].ToString();
                        R.UrlPDF = dr["UrlPDF"].ToString();
                        R.UrlSTEP = dr["UrlSTEP"].ToString();

                        // Propiedades de Navegación

                        R.MyWasherType.IDWasherType = Convert.ToInt32(dr["IDWasherType"].ToString());
                        R.MyWasherType.WasherTypeName = dr["WasherTypeName"].ToString();

                        R.MyWasherSize.IDWasherSize = Convert.ToInt32(dr["IDWasherSize"].ToString());
                        R.MyWasherSize.WasherSizeName = dr["WasherSizeName"].ToString();
                    }
                }
            }
            return R;
        }

        public Washers SelectWasherBySize(string SizeName, string TypeName)
        {
            Washers R = new Washers();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM View_WasherSelectedBySize WHERE Active = 1 AND WasherTypeName = @WasherTypeName AND WasherSizeName = @WasherSizeName", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@WasherTypeName", TypeName));
                cmd.Parameters.Add(new SQLiteParameter("@WasherSizeName", SizeName));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDWasher = Convert.ToInt32(dr["IDWasher"].ToString());
                        R.SSNEPartNumber = dr["SSNEPartNumber"].ToString();
                        R.VendorPartNumber = dr["VendorPartNumber"].ToString();
                        R.UrlPDF = dr["UrlPDF"].ToString();
                        R.UrlSTEP = dr["UrlSTEP"].ToString();

                        // Propiedades de Navegación

                        R.MyWasherType.IDWasherType = Convert.ToInt32(dr["IDWasherType"].ToString());
                        R.MyWasherType.WasherTypeName = dr["WasherTypeName"].ToString();

                        R.MyWasherSize.IDWasherSize = Convert.ToInt32(dr["IDWasherSize"].ToString());
                        R.MyWasherSize.WasherSizeName = dr["WasherSizeName"].ToString();
                    }
                }
            }
            return R;
        }

        public bool Guardar(Washers obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into Washers (IDWasherSize, IDWasherType, SSNEPartNumber, VendorPartNumber, UrlPDF, UrlSTEP) " +
                    "values (@IDWasherSize, @IDWasherType, @SSNEPartNumber, @VendorPartNumber, @UrlPDF, @UrlSTEP)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDWasherSize", obj.MyWasherSize.IDWasherSize));
                cmd.Parameters.Add(new SQLiteParameter("@IDWasherType", obj.MyWasherType.IDWasherType));
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
       

        public bool Editar(Washers obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update Washers set IDWasherType = @IDWasherType, IDWasherSize = @IDWasherSize, " +
                    "SSNEPartNumber = @SSNEPartNumber, VendorPartNumber = @VendorPartNumber, " +
                    "UrlPDF = @UrlPDF, UrlSTEP = @UrlSTEP WHERE IDWasher = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDWasherType", obj.MyWasherType.IDWasherType));
                cmd.Parameters.Add(new SQLiteParameter("@IDWasherSize", obj.MyWasherSize.IDWasherSize));
                cmd.Parameters.Add(new SQLiteParameter("@SSNEPartNumber", obj.SSNEPartNumber));
                cmd.Parameters.Add(new SQLiteParameter("@VendorPartNumber", obj.VendorPartNumber));
                cmd.Parameters.Add(new SQLiteParameter("@UrlPDF", obj.UrlPDF));
                cmd.Parameters.Add(new SQLiteParameter("@UrlSTEP", obj.UrlSTEP));

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDWasher));
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
