﻿using System;
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
            Deelnemers = new Zwemmer[deelnemers.Length];
            Deelnemers = deelnemers;
            Sheids = sheids;
            Slag = slag;
        }

        public void StartWedstrijd()
        {
            foreach (var zwemmer in Deelnemers)
            {

            }
        }

        public override string ToString()
        {
            return null;
        }
    }
}
