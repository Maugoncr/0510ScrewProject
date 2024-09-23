using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Nuts
    {
        public int IDNuts { get; set; }

        public string SSNEPartNumber { get; set; }
        public string VendorPartNumber { get; set; }

        public string UrlPDF { get; set; }
        public string UrlSTEP { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

        // FK's

        public int IDNutsSize { get; set; }
        public int IDNutsType { get; set; }

        // Propiedades de Navegación

        public NutsSize MyNutSize { get; set; }
        public NutsType MyNutType { get; set; }

        public Nuts()
        {
            MyNutSize = new NutsSize();
            MyNutType = new NutsType();
        }

    }
}
