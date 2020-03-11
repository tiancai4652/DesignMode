using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DesignModeBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Why { get; set; }
        public List<string> Advantage { get; set; }
        public List<string> Weakness { get; set; }
        public string implementation { get; set; }
        public List<Tips> Tips { get; set; }
    }
}
