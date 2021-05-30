using System;
using System.Collections.Generic;
using System.Linq;

namespace Summatieve3
{
    class Treinrit : Stap
    {
        public int Minuten;

        public Treinrit(string _name, int _tijdInMin) : base(_name)
        {
            Minuten = _tijdInMin;
        }
        public override int GetCost()
        {
            return Minuten;
        }
        public override void SetCostOfSelf(int _cost)
        {
            Minuten = _cost;
        }
    }
}
