using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ScrewAvailableTool
    {
        public int IDScrewTool { get; set; }

        public string ToolName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

    }
}
