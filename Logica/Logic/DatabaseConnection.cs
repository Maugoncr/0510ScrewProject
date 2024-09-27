using System;
using System.Configuration;
using System.IO;

namespace Logica.Logic
{
    public class DatabaseConnection
    {
        public static string GetConnectionString()
        {
            // Obtener la ruta del directorio AppData/Roaming
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string dbPath = Path.Combine(appDataPath, "0510Software", "DataBaseSQLite", "0510Project.db");

            // Construir la cadena de conexión con la ruta de la base de datos
            string connectionString = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            connectionString = connectionString.Replace("Data Source=;", $"Data Source={dbPath};");

            return connectionString;
        }
    }
}
