using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summatieve3
{
    interface IComparable<T>
    {
        public bool CompareTo(T obj1, T obj2);
    }
}
