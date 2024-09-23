using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class NutsSize
    {
        public int IDNutsSize { get; set; }

        public string NutsSizeName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }
    }
}
