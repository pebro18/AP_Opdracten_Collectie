using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Opdracten_Collectie.Summatieve_1
{
    class Tournooi
    {
        public Wedstrijd[] Wedstrijden { get; set; }

        public Tournooi(Wedstrijd[] wedstrijden)
        {
            Wedstrijden = new Wedstrijd[wedstrijden.Length];
            Wedstrijden = wedstrijden;
        }
    }
}
