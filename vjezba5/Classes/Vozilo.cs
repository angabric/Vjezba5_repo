using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba5
{
    abstract class Vozilo
    {
        public List<Dio> montiraniDijelovi;
        public string naziv { get; set; }
        public int status { get; set; }
        public int tezina { get; set; }
        public int visina { get; set; }
        public int duzina { get; set; }
        public int meduosovinskiRazmak { get; set; }
        public string gume { get; set; }
        public int co2 { get; set; }
        public VIN idAutomobila;

        public Vozilo()
        {
            montiraniDijelovi = new List<Dio>();
            idAutomobila = new VIN(10, 15, 30);

        }

        public bool addDio(Dio noviDio)
        {
            montiraniDijelovi.Add(noviDio);
            return true;
        }

        public void updateStatus()
        {
            status += status++;
        }

        public List<Dio> getDjelovi()
        {
            return montiraniDijelovi;
        }
    }


}
