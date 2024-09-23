using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class WasherSize
    {
        public int IDWasherSize { get; set; }

        public string WasherSizeName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

    }
}
