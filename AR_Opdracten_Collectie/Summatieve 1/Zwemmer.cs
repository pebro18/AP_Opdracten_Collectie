using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Opdracten_Collectie.Summatieve_1
{
    class Zwemmer : Persoon, IDeelnemer
    {
        public List<Tuple<TypeZwemSlag, float>> ZwemmerTijden { get; set; }

        public Zwemmer(string naam, int leeftijd, List<Tuple<TypeZwemSlag, float>> zwemmerTijden = null)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            ZwemmerTijden = new();
            ZwemmerTijden = zwemmerTijden;
        }

        public void SetBestTime(TypeZwemSlag type, float tijd)
        {
            
        }

        public float GetBestTime(TypeZwemSlag type)
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
