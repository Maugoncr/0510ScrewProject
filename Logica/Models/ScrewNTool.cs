using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ScrewNTool
    {
        public int IDScrewNTool { get; set; }

        public string NToolName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

    }
}
