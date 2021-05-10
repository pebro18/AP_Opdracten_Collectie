using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Opdracten_Collectie.Summatieve_1
{
    interface IDeelnemer
    {
        public List<Tuple<TypeZwemSlag, float>> ZwemmerTijden { get; set; }

        public void SetBestTime(TypeZwemSlag type, float tijd);

        public float GetBestTime(TypeZwemSlag type);
    }
}
