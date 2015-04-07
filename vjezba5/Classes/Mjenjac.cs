using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba5
{
    class Mjenjac : Dio
    {

        public string naziv { get; set; }
        public int sifra { get; set; }

        public int brojBrzina { get; set; }
        public EnumHelper.MjenjacTip tip { get; set; }

        public Mjenjac(int brojBrzina, EnumHelper.MjenjacTip tip)
        {
            this.brojBrzina = brojBrzina;
            this.tip = tip;
        }

        public string printAttributes()
        {
            string attributes = "Broj brzina: " + brojBrzina.ToString();
            attributes += " ";
            attributes += "Tip: " + tip.ToString();

            return attributes;
        }
    }
}
