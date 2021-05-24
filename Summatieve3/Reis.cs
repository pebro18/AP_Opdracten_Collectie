using System;
using System.Collections.Generic;
using System.Linq;

namespace Summatieve3
{
    class Reis : IComparable<Stap>
    {
        List<Stap> Stappen;
        Queue<Stap> ReisRij;

        public bool CompareTo(Stap obj1, Stap obj2)
        {
            return false;
        }

        public void AddStap(Stap _stap)
        {
            Stappen.Add(_stap);
        }

    }
}
