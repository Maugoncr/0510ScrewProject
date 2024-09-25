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

        // PENDIENTE
        public Washers SelectScrewByTypeSizeLength(int IDType, int IDSize)
        {
            Washers R = new Washers();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM View_ScrewSelectedByTypeSizeLength WHERE IDScrewType = @IDType AND IDScrewSize = @IDSize AND IDScrewLength = @IDLength", conn))
            {
                cmd.Parameters.Add(new SQLiteParameter("@IDType", IDType));
                cmd.Parameters.Add(new SQLiteParameter("@IDSize", IDSize));
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

        public bool Guardar(Washers obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Insert into Screw (IDType, IDSize, IDLength, IDNTool, IDMaterial, IDAbbreviation, SSNEPartNumber, VendorPartNumber, UrlPDF, UrlSTEP) " +
                    "values (@IDType, @IDSize, @IDLength, @IDNTool , @IDMaterial , @IDAbbreviation, @SSNEPartNumber, @VendorPartNumber, @UrlPDF, @UrlSTEP)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDType", obj.MyScrewType.IDScrewType));
                cmd.Parameters.Add(new SQLiteParameter("@IDSize", obj.MyScrewSize.IDScrewSize));
                cmd.Parameters.Add(new SQLiteParameter("@IDLength", obj.MyScrewLength.IDScrewLength));
                cmd.Parameters.Add(new SQLiteParameter("@IDNTool", obj.MyScrewNTool.IDScrewNTool));
                cmd.Parameters.Add(new SQLiteParameter("@IDMaterial", obj.MyScrewMaterial.IDScrewMaterial));
                cmd.Parameters.Add(new SQLiteParameter("@IDAbbreviation", obj.MyScrewAbbreviation.IDScrewAbbreviation));
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


        public bool SaveScrewAndScrew_Tool(Screw obj, List<Screw_Tool> screw_tool)
        {
            bool respuesta = true;

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Registrar el nuevo tornillo
                        string firstQuery = "Insert into Screw (IDType, IDSize, IDLength, IDNTool, IDMaterial, IDAbbreviation, SSNEPartNumber, VendorPartNumber, UrlPDF, UrlSTEP) " +
                    "values (@IDType, @IDSize, @IDLength, @IDNTool , @IDMaterial , @IDAbbreviation, @SSNEPartNumber, @VendorPartNumber, @UrlPDF, @UrlSTEP)";

                        using (SQLiteCommand cmd = new SQLiteCommand(firstQuery, conn))
                        {
                            cmd.Parameters.Add(new SQLiteParameter("@IDType", obj.MyScrewType.IDScrewType));
                            cmd.Parameters.Add(new SQLiteParameter("@IDSize", obj.MyScrewSize.IDScrewSize));
                            cmd.Parameters.Add(new SQLiteParameter("@IDLength", obj.MyScrewLength.IDScrewLength));
                            cmd.Parameters.Add(new SQLiteParameter("@IDNTool", obj.MyScrewNTool.IDScrewNTool));
                            cmd.Parameters.Add(new SQLiteParameter("@IDMaterial", obj.MyScrewMaterial.IDScrewMaterial));
                            cmd.Parameters.Add(new SQLiteParameter("@IDAbbreviation", obj.MyScrewAbbreviation.IDScrewAbbreviation));
                            cmd.Parameters.Add(new SQLiteParameter("@SSNEPartNumber", obj.SSNEPartNumber));
                            cmd.Parameters.Add(new SQLiteParameter("@VendorPartNumber", obj.VendorPartNumber));
                            cmd.Parameters.Add(new SQLiteParameter("@UrlPDF", obj.UrlPDF));
                            cmd.Parameters.Add(new SQLiteParameter("@UrlSTEP", obj.UrlSTEP));

                            cmd.ExecuteNonQuery();
                        }

                        // Obtener el id generado por el new Screw (last_insert_rowid)
                        int idNewScrew;
                        string queryGetIDScrew = "SELECT last_insert_rowid();";
                        using (SQLiteCommand cmd = new SQLiteCommand(queryGetIDScrew, conn))
                        {
                            idNewScrew = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        foreach (var data in screw_tool)
                        {
                            string queryScrew_Tool = "INSERT INTO Screw_Tool (IDScrewTool, IDScrew) values (@IDScrewTool, @IDScrew)";

                            using (SQLiteCommand cmd = new SQLiteCommand(queryScrew_Tool, conn))
                            {
                                cmd.Parameters.AddWithValue("@IDScrewTool", data.IDScrewTool);
                                cmd.Parameters.AddWithValue("@IDScrew", idNewScrew);

                                if (cmd.ExecuteNonQuery() < 1)
                                {
                                    respuesta = false;
                                }
                            }
                        }

                        transaction.Commit();

                        return respuesta;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error adding the screw: " + ex.Message);
                    }
                }
            }
        }

        public bool Editar(Screw obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "Update Screw set IDType = @IDType, IDSize = @IDSize, IDLength = @IDLength, IDNTool = @IDNTool, IDMaterial = @IDMaterial, " +
                    "IDAbbreviation = @IDAbbreviation, SSNEPartNumber = @SSNEPartNumber, VendorPartNumber = @VendorPartNumber, " +
                    "UrlPDF = @UrlPDF, UrlSTEP = @UrlSTEP WHERE IDScrew = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDType", obj.MyScrewType.IDScrewType));
                cmd.Parameters.Add(new SQLiteParameter("@IDSize", obj.MyScrewSize.IDScrewSize));
                cmd.Parameters.Add(new SQLiteParameter("@IDLength", obj.MyScrewLength.IDScrewLength));
                cmd.Parameters.Add(new SQLiteParameter("@IDNTool", obj.MyScrewNTool.IDScrewNTool));
                cmd.Parameters.Add(new SQLiteParameter("@IDMaterial", obj.MyScrewMaterial.IDScrewMaterial));
                cmd.Parameters.Add(new SQLiteParameter("@IDAbbreviation", obj.MyScrewAbbreviation.IDScrewAbbreviation));
                cmd.Parameters.Add(new SQLiteParameter("@SSNEPartNumber", obj.SSNEPartNumber));
                cmd.Parameters.Add(new SQLiteParameter("@VendorPartNumber", obj.VendorPartNumber));
                cmd.Parameters.Add(new SQLiteParameter("@UrlPDF", obj.UrlPDF));
                cmd.Parameters.Add(new SQLiteParameter("@UrlSTEP", obj.UrlSTEP));

                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrew));
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
