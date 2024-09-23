using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class WasherType
    {
        public int IDWasherType { get; set; }

        public string WasherTypeName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }
    }
}
