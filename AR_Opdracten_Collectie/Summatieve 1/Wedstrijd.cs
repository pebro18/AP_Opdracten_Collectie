using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Opdracten_Collectie.Summatieve_1
{
    class Wedstrijd
    {
        Zwemmer Winnaar { get; set; }
        Zwemmer[] Deelnemers;
        Sheidsrechter Sheids;
        TypeZwemSlag Slag;

        public Wedstrijd(Zwemmer[] deelnemers, Sheidsrechter sheids, TypeZwemSlag slag)
        {
            Deelnemers = deelnemers;
            Sheids = sheids;
            Slag = slag;
        }

        void StartWedstrijd()
        {
            
        }

        public override string ToString()
        {
            return null;
        }
    }
}
