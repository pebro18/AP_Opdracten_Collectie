using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summatieve3
{
    class Vlucht : Stap
    {
        public int Kosten;

        public Vlucht(string _name, int _prijs) : base(_name)
        {
            Kosten = _prijs;
        }

        public override int GetCost()
        {
            return Kosten;
        }

        public override void SetCostOfSelf(int _cost)
        {
            Kosten = _cost;
        }
    }
}
