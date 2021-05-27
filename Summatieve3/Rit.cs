using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summatieve3
{
    class Rit : Stap
    {
        public int Kilometers;

        public Rit(string _name, int _afstandInKm) : base(_name)
        {
            Kilometers = _afstandInKm;
        }

        public override int GetCost()
        {
            return Kilometers;
        }

        public override void SetCostOfSelf(int _cost)
        {
            Kilometers = _cost;

        }
    }
}
