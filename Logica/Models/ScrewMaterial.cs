using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ScrewMaterial
    {
        public int IDScrewMaterial { get; set; }

        public string MaterialName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

    }
}
