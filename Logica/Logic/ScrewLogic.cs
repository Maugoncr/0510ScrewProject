using Logica.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

    }
}
