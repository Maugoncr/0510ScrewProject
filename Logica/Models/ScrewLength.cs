using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ScrewLength
    {
        public int IDScrewLength { get; set; }
        public string LengthInch { get; set; }
        public string LengthDecimal { get; set; }
        public string LengthMetric { get; set; }

        [Browsable(false)]
        public int Active { get; set; }
    }
}
