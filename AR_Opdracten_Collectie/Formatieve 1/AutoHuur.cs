using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Opdracten_Collectie.Formatieve
{
    class TestCode
    {
        //static void Main()
        //{
        //    AutoHuur ah1 = new();
        //    Console.WriteLine("Eerste autohuur: " + ah1.toString());

        //    Klant k = new("Mijnheer de Vries");
        //    k.SetKorting(10.0);
        //    ah1.SetHuurder(k);
        //    Console.WriteLine("Eerste autohuur: " + ah1.toString());

        //    Auto a1 = new("Peugeot 207", 50);
        //    ah1.SetGehuurdeAuto(a1);
        //    ah1.SetAantalDagen(4);
        //    Console.WriteLine("Eerste autohuur: " + ah1.toString());

        //    AutoHuur ah2 = new();
        //    Auto a2 = new("Ferrari", 3500);
        //    ah2.SetGehuurdeAuto(a2);
        //    ah2.SetHuurder(k);
        //    ah2.SetAantalDagen(1);
        //    Console.WriteLine("Tweede autohuur: " + ah2.toString());

        //    Console.WriteLine("Gehuurd: " + ah1.GetGehuurdeAuto());
        //    Console.WriteLine("Gehuurd: " + ah2.GetGehuurdeAuto());
        //}
    }

    public class AutoHuur
    {
        int aantalDagen;
        Klant huurder;
        Auto gehuurdeAuto;

        public AutoHuur() { }

        public void SetAantalDagen(int aD)
        {
            aantalDagen = aD;
        }

        public void SetGehuurdeAuto(Auto gA)
        {
            gehuurdeAuto = gA;
        }

        public Auto GetGehuurdeAuto()
        {
            return gehuurdeAuto;
        }

        public void SetHuurder(Klant k)
        {
            huurder = k;
        }

        public Klant GetHuurder()
        {
            return huurder;
        }

        double TotaalPrijs()
        {
            if (huurder != null && gehuurdeAuto != null)
            {
                return (gehuurdeAuto.GetPrijsPerDag() * aantalDagen) * (1-huurder.GetKorting()/100);
            }
            else
            {
                return 0.0;
            } 
        }

        public string toString()
        {
            string Output = "";
            if (gehuurdeAuto != null)
            {
                Output += gehuurdeAuto.toString();
            }
            else
            {
                Output += "er is geen auto bekend\n";
            }
            if (GetHuurder() != null)
            {
                Output += huurder.toString();
            }
            else
            {
                Output += "er is huurder bekend\n";
            }
            Output += string.Format("aantal dagen: {0} en dat kost {1}", aantalDagen, TotaalPrijs());

            return Output;
        }
    }

    public class Auto
    {
        private string type;
        private double prijsPerDag;

        public Auto(string tp, double prPd)
        {
            type = tp;
            prijsPerDag = prPd;
        }

        public void SetPrijsPerDag(double prPd)
        {
            prijsPerDag = prPd;
        }

        public double GetPrijsPerDag()
        {
            return prijsPerDag;
        }

        public string toString()
        {
            string Output = "";
            if (type != null && prijsPerDag != 0)
            {
                Output += String.Format("autotype : {0} met prijs per dag: {1}\n", type, prijsPerDag);
            }

            return Output;
        }

    }

    public class Klant
    {
        private string naam;
        private double kortingPercentage;

        public Klant(string nm)
        {
            naam = nm;
        }

        public void SetKorting(double kP)
        {
            kortingPercentage = kP;
        }

        public double GetKorting()
        {
            return kortingPercentage;
        }

        public string toString()
        {
            string Output = "";
            if (naam != null)
            {
                Output += String.Format("op de naam van: {0} (korting: {1} %)\n", naam, kortingPercentage);
            }

            return Output;
        }
    }
}
