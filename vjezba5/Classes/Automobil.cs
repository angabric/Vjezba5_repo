using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba5
{
    class Automobil : Vozilo
    {
        public int volumenPrtljaznika { get; set; }
        public int ncap { get; set; }
        public int vrata { get; set; }
        public EnumHelper.Kocnice prednjeKocnice { get; set; }
        public EnumHelper.Kocnice zadnjeKocnice { get; set; }

    }
}
