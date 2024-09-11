
using System.ComponentModel;


namespace Logica.Models
{
    public class Screw
    {
        public int IDScrew { get; set; }

        public string SSNEPartNumber { get; set; }
        public string VendorPartNumber { get; set; }

        public string UrlPDF { get; set; }
        public string UrlSTEP { get; set; }

        [Browsable (false)]
        public int Active { get; set; }

        // FK's

        public int IDType { get; set; }
        public int IDSize { get; set; }
        public int IDLength { get; set; }
        public int IDNTool { get; set; }
        public int IDMaterial { get; set; }
        public int IDAbbreviation { get; set; }

        // Propiedades de Navegación

        public ScrewType MyScrewType { get; set; }
        public ScrewSize MyScrewSize { get; set; }
        public ScrewLength MyScrewLength { get; set; }
        public ScrewNTool MyScrewNTool { get; set; }
        public ScrewMaterial MyScrewMaterial { get; set; }
        public ScrewAbbreviation MyScrewAbbreviation { get; set; }

        public Screw()
        {
            MyScrewType = new ScrewType();
            MyScrewSize = new ScrewSize();
            MyScrewLength   = new ScrewLength();
            MyScrewNTool = new ScrewNTool();
            MyScrewMaterial = new ScrewMaterial();
            MyScrewAbbreviation = new ScrewAbbreviation();
        }
    }
}
