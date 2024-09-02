using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ScrewType
    {
        public int IDScrewType { get; set; }

        public string TypeName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

    }
}
