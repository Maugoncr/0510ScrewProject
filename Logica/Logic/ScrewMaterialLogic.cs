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
    public class ScrewMaterialLogic
    {

            private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            private static ScrewMaterialLogic _instancia = null;

            public ScrewMaterialLogic()
            {

            }

            public static ScrewMaterialLogic Instancia
            {
                get
                {
                    if (_instancia == null)
                    {
                        _instancia = new ScrewMaterialLogic();
                    }
                    return _instancia;
                }
            }


            public bool Guardar(ScrewMaterial obj)
            {
                bool respuesta = true;

                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    string query = "Insert into ScrewMaterial (MaterialName) values (@MaterialName)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.Add(new SQLiteParameter("@MaterialName", obj.MaterialName));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }

                return respuesta;
            }

            public List<ScrewMaterial> Listar(bool VerActivos, string Filter)
            {
                List<ScrewMaterial> oLista = new List<ScrewMaterial>();

                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    string query = "Select IDScrewMaterial, MaterialName FROM ScrewMaterial WHERE Active = @Active ORDER BY IDScrewMaterial ASC";

                    if (Filter != null || Filter != "")
                    {
                        query = "Select IDScrewMaterial, MaterialName FROM ScrewMaterial WHERE Active = @Active AND MaterialName LIKE '%' || @Filter || '%' ORDER BY IDScrewMaterial ASC";
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
                            oLista.Add(new ScrewMaterial()
                            {
                                IDScrewMaterial = int.Parse(dr["IDScrewMaterial"].ToString()),
                                MaterialName = dr["MaterialName"].ToString()
                            });
                        }
                    }
                }
                return oLista;
            }

            public ScrewMaterial SelectByID(int ID)
            {
                ScrewMaterial R = new ScrewMaterial();

                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT IDScrewMaterial, MaterialName FROM ScrewMaterial WHERE IDScrewMaterial = @ID", conn))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                    conn.Open();

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            R.IDScrewMaterial = Convert.ToInt32(dr["IDScrewMaterial"].ToString());
                            R.MaterialName = dr["MaterialName"].ToString();
                        }
                    }
                }
                return R;
            }


            public bool Editar(ScrewMaterial obj)
            {
                bool respuesta = true;

                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    string query = "Update ScrewMaterial set MaterialName = @MaterialName WHERE IDScrewMaterial = @ID";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.Add(new SQLiteParameter("@MaterialName", obj.MaterialName));
                    cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewMaterial));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }

                return respuesta;
            }

            public bool Disable_Enable(ScrewMaterial obj)
            {
                bool respuesta = true;

                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    string query = "Update ScrewMaterial set Active = @Active WHERE IDScrewMaterial = @ID";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.Add(new SQLiteParameter("@ID", obj.IDScrewMaterial));
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
