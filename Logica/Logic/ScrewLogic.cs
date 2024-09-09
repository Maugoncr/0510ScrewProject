using Logica.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logic
{
    public class ScrewLogic
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ScrewLogic _instancia = null;

        public ScrewLogic()
        {

        }

        public static ScrewLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ScrewLogic();
                }
                return _instancia;
            }
        }

        public DataTable Listar(bool VerActivos, string Filter)
        {
            DataTable R = new DataTable();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "SELECT * FROM View_ScrewsList WHERE Active = @Active ORDER BY IDScrew ASC";

                if (Filter != null && Filter != "")
                {
                    query = "SELECT * FROM View_ScrewsList WHERE Active = @Active AND TypeName LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND SizeName LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND LengthInch LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND MaterialName LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND AbbreviationName LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND NToolName LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND SSNEPartNumber LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND VendorPartNumber LIKE '%' || @Filter || '%' OR " +
                        "Active = @Active AND IDScrew LIKE '%' || @Filter || '%' ORDER BY IDScrew ASC";
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
                    // Cargar los resultados en el DataTable
                    R.Load(dr);
                    R.Columns.RemoveAt(3);
                }
            }
            return R;
        }

        public Screw SelectScrewByID(int ID)
        {
            Screw R = new Screw();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM View_ScrewSelectedByID WHERE IDScrew = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        R.IDScrew = Convert.ToInt32(dr["IDScrew"].ToString());
                        R.SSNEPartNumber = dr["SSNEPartNumber"].ToString();
                        R.VendorPartNumber = dr["VendorPartNumber"].ToString();
                        R.UrlPDF = dr["UrlPDF"].ToString();
                        R.UrlSTEP = dr["UrlSTEP"].ToString();

                        // Propiedades de Navegación

                        R.MyScrewType.IDScrewType = Convert.ToInt32(dr["IDScrewType"].ToString());
                        R.MyScrewType.TypeName = dr["TypeName"].ToString();

                        R.MyScrewSize.IDScrewSize = Convert.ToInt32(dr["IDScrewSize"].ToString());
                        R.MyScrewSize.SizeName = dr["SizeName"].ToString();

                        R.MyScrewMaterial.IDScrewMaterial = Convert.ToInt32(dr["IDScrewMaterial"].ToString());
                        R.MyScrewMaterial.MaterialName = dr["MaterialName"].ToString();

                        R.MyScrewLength.IDScrewLength = Convert.ToInt32(dr["IDScrewLength"].ToString());
                        R.MyScrewLength.LengthInch = dr["LengthInch"].ToString();

                        R.MyScrewAbbreviation.IDScrewAbbreviation = Convert.ToInt32(dr["IDScrewAbbreviation"].ToString());
                        R.MyScrewAbbreviation.AbbreviationName = dr["AbbreviationName"].ToString();

                        R.MyScrewNTool.IDScrewNTool = Convert.ToInt32(dr["IDScrewNTool"].ToString());
                        R.MyScrewNTool.NToolName = dr["NToolName"].ToString();
                    }
                }
            }
            return R;
        }

        public DataTable SelectScrewAvailableToolsByID(int ID)
        { 
            DataTable R = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM View_ScrewSelectedByIDAvailableToolsList WHERE IDScrew = @ID", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    R.Load(dr);
                    R.Columns.RemoveAt(2);
                }
            }
            return R;
        }

    }
}
