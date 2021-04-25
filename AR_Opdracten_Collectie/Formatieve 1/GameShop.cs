using System;
using System.Collections.Generic;

namespace AP_Opdracten_Collectie.Formatieve
{
    class TestGameShop
    {
        //static void Main()
        //{
        //    int releaseJaar1 = DateTime.Now.Year - 1; // 1 jaar geleden
        //    int releaseJaar2 = DateTime.Now.Year - 2; // 2 jaar geleden

        //    Game g1 = new("Just Cause 3", releaseJaar1, 49.98);
        //    Game g2 = new("Need for Speed: Rivals", releaseJaar2, 45.99);
        //    Game g3 = new("Need for Speed: Rivals", releaseJaar2, 45.99);

        //    Persoon p1 = new("Eric", 200);
        //    Persoon p2 = new("Hans", 55);
        //    Persoon p3 = new("Arno", 185);

        //    // Druk de volgende transacties af (pas de code aan)
        //    p1.Koop(g1);
        //    p1.Koop(g2);
        //    p1.Koop(g3);
        //    p2.Koop(g2);
        //    p2.Koop(g1);
        //    p3.Koop(g3);

        //    Console.WriteLine("\n");

        //    // Druk personen p1 p2 p3 nu af naar de console
        //    Console.WriteLine("p1: " + p1.name + " heeft een budget van " + p1.budget + " en bezit de volgende games:\n");
        //    PrintOutPersoonLibary(p1);

        //    Console.WriteLine("p2: " + p2.name + " heeft een budget van " + p2.budget + " en bezit de volgende games:\n");
        //    PrintOutPersoonLibary(p2);

        //    Console.WriteLine("p3: " + p3.name + " heeft een budget van " + p3.budget + " en bezit de volgende games:\n");
        //    PrintOutPersoonLibary(p3);

        //    // Druk de volgende transacties af (pas de code aan)
        //    p1.Verkoop(g1, p3);
        //    p2.Verkoop(g2, p3);
        //    p2.Verkoop(g1, p1);
        //    Console.WriteLine("\n");

        //    // Druk personen p1 p2 p3 nu af naar de console
        //    Console.WriteLine("p1: " + p1.name + " heeft een budget van " + p1.budget + " en bezit de volgende games:\n");
        //    PrintOutPersoonLibary(p1);

        //    Console.WriteLine("p2: " + p2.name + " heeft een budget van " + p2.budget + " en bezit de volgende games:\n");
        //    PrintOutPersoonLibary(p2);

        //    Console.WriteLine("p3: " + p3.name + " heeft een budget van " + p3.budget + " en bezit de volgende games:\n");
        //    PrintOutPersoonLibary(p3);
        //}

        private static void PrintOutPersoonLibary(Persoon _p)
        {
            foreach (var game in _p.gameVerzameling)
            {
                double newprice = GetGameNewPrice(game);
                Console.WriteLine(game.name + ", uitgegeven in " + game.releaseyear + "; nieuwprijs:" + game.prijs + " nu voor: " + newprice + "\n");
            }
        }

        public static double GetGameNewPrice(Game _game)
        {
            int yeardiffrence = DateTime.Now.Year - _game.releaseyear;
            double newprice = _game.prijs * Math.Pow(0.70, yeardiffrence);
            return newprice;
        }
    }

    class Game
    {
        public string name;
        public int releaseyear;
        public double prijs;

        public Game(string nm, int dt, double pr)
        {
            name = nm;
            releaseyear = dt;
            prijs = pr;
        }
    }

    class Persoon
    {
        public string name;
        public double budget;
        public List<Game> gameVerzameling = new();

        public Persoon(string nm, int bd)
        {
            name = nm;
            budget = bd;
        }

        public void Koop(Game _game)
        {
            
            bool InVerzameling = gameVerzameling.Exists(x => x.name == _game.name);
            if (budget >= _game.prijs && !InVerzameling)
            {
                Console.WriteLine(name + " koopt " + _game.name + " gelukt");
                budget -= TestGameShop.GetGameNewPrice(_game);
                gameVerzameling.Add(_game);
            }
            else
            {
                Console.WriteLine(name + " koopt " + _game.name + " niet gelukt");
            }
        }

        public void Verkoop(Game _game, Persoon _anderepersoon)
        {
            bool InBezit = gameVerzameling.Exists(x => x.name == _game.name);
            bool InVerzamelingVanAnder = _anderepersoon.gameVerzameling.Exists(x => x.name == _game.name);

            if (_anderepersoon.budget >= _game.prijs && !InVerzamelingVanAnder && InBezit)
            {
                double _gameprijs = TestGameShop.GetGameNewPrice(_game);

                Console.WriteLine(name + " verkoopt " + _game.name + " aan " + _anderepersoon.name + " gelukt");

                _anderepersoon.budget -= _gameprijs;
                budget += _gameprijs;
                gameVerzameling.Remove(_game);
                _anderepersoon.gameVerzameling.Add(_game);
            }
            else
            {
                Console.WriteLine(name + " verkoopt " + _game.name + " aan " + _anderepersoon.name + ": niet gelukt");
            }

        }
    }
}
