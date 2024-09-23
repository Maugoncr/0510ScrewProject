using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Washers
    {
        public int IDWasher { get; set; }

        public string SSNEPartNumber { get; set; }
        public string VendorPartNumber { get; set; }

        public string UrlPDF { get; set; }
        public string UrlSTEP { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

        // FK's

        public int IDWasherSize { get; set; }
        public int IDWasherType { get; set; }

        // Propiedades de Navegación

        public WasherSize MyWasherSize { get; set; }
        public WasherType MyWasherType { get; set; }

        public Washers()
        {
            MyWasherSize = new WasherSize();
            MyWasherType = new WasherType();
        }

    }
}
