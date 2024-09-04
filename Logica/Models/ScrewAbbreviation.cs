using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ScrewAbbreviation
    {

        public int IDScrewAbbreviation { get; set; }

        public string AbbreviationName { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

    }
}
