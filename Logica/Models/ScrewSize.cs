using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ScrewSize
    {

        public int IDScrewSize { get; set; }

        public string SizeName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

    }
}
