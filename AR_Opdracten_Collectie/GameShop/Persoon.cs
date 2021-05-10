using System;
using System.Collections.Generic;

namespace AP_Opdracten_Collectie.Formatieve
{
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
