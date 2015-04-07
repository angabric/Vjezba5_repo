using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            vjezba5.Automobil noviAutomobil = new vjezba5.Automobil();

            noviAutomobil.naziv = "Jetta";
            noviAutomobil.tezina = 1300;
            noviAutomobil.visina = 1440;
            noviAutomobil.duzina = 4644;
            noviAutomobil.meduosovinskiRazmak = 2651;
            noviAutomobil.gume = "195/65/15";
            noviAutomobil.co2 = 119;
            noviAutomobil.volumenPrtljaznika = 510;
            noviAutomobil.ncap = 5;
            noviAutomobil.vrata = 4;
            noviAutomobil.prednjeKocnice = vjezba5.EnumHelper.Kocnice.Diskovi;
            noviAutomobil.zadnjeKocnice = vjezba5.EnumHelper.Kocnice.Bubanj;

            vjezba5.Dio motor = new vjezba5.Motor(4, 1600, 105, vjezba5.EnumHelper.Gorivo.Dizel);
            motor.naziv = "Motor TDI";
            motor.sifra = 17;

            noviAutomobil.addDio(motor);

            noviAutomobil.addDio(new vjezba5.Mjenjac(6, vjezba5.EnumHelper.MjenjacTip.Manual) { naziv = "Mjenjac", sifra = 12});

            foreach (vjezba5.Dio d in noviAutomobil.getDjelovi())
            {
                rtbMain.AppendText(d.naziv + " - " + d.printAttributes() + " \n");
                rtbMain.AppendText("\n");
            }

            rtbMain.AppendText("Vin: " + noviAutomobil.idAutomobila.getVin());
        }


    }
}
