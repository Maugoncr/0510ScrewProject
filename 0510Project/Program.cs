using _0510Project.Forms;
using _0510Project.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0510Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Define las subcarpetas
            string softwareFolder = Path.Combine(appDataPath, "0510Software");
            string databaseFolder = Path.Combine(softwareFolder, "DataBaseSQLite");

            // Crea las carpetas si no existen
            if (!Directory.Exists(softwareFolder))
            {
                Directory.CreateDirectory(softwareFolder);
            }

            if (!Directory.Exists(databaseFolder))
            {
                Directory.CreateDirectory(databaseFolder);
            }

            // Define la ruta completa al archivo de base de datos
            string databaseFilePath = Path.Combine(databaseFolder, "0510Project.db");
            // Comprueba si el archivo de base de datos existe en la carpeta destino
            if (!File.Exists(databaseFilePath))
            {
                // Define la ruta del archivo en la raíz del proyecto
                string sourceFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "0510Project.db");
                // Copia el archivo desde la raíz del proyecto a la carpeta destino
                File.Copy(sourceFilePath, databaseFilePath);
            }

            Settings.Default.DBPath = databaseFolder;
            Settings.Default.Save();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
