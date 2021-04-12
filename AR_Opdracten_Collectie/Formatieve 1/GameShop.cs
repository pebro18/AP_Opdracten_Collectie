using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Opdracten_Collectie.Formatieve
{
    class TestGameShop
    {
        static void Main()
        {
            int releaseJaar1 = DateTime.Now.Year - 1; // 1 jaar geleden
            int releaseJaar2 = DateTime.Now.Year - 2; // 2 jaar geleden


            Game g1 = new("Just Cause 3", releaseJaar1, 49.98);
            Game g2 = new("Need for Speed: Rivals", releaseJaar2, 45.99);
            Game g3 = new("Need for Speed: Rivals", releaseJaar2, 45.99);


            Persoon p1 = new("Eric", 200);
            Persoon p2 = new("Hans", 55);
            Persoon p3 = new("Arno", 185);


            // Druk de volgende transacties af (pas de code aan)
            p1.Koop(g1);
            p1.Koop(g2);
            p1.Koop(g3);
            p2.Koop(g2);
            p2.Koop(g1);
            p3.Koop(g3);


            // Druk personen p1 p2 p3 nu af naar de console


            // Druk de volgende transacties af (pas de code aan)
            p1.Verkoop(g1, p3);
            p2.Verkoop(g2, p3);
            p2.Verkoop(g1, p1);


            // Druk personen p1 p2 p3 nu af naar de console
        }
    }

    class Game
    {
        public string name;
        public int releaseyear;
        public double prijs;

        public Game(string nm,int dt,double pr)
        {
            name = nm;
            releaseyear = dt;
            prijs = pr;
        }

    }

    class Persoon
    {
        string name;
        double budget;
        List<Game> GameVerzameling = new List<Game>();


        public Persoon(string nm,int bd)
        {
            name = nm;
            budget = bd;
        }

        public void Koop(Game _game)
        {
            if (budget >= _game.prijs)
            {
                GameVerzameling.Add(_game);
            }
        }

        public void Verkoop(Game _game, Persoon _anderepersoon)
        {

        }

    }
}
