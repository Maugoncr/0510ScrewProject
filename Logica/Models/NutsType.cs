using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class NutsType
    {
        public int IDNutsType { get; set; }

        public string NutsTypeName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

    }
}
