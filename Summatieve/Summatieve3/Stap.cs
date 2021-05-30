using System.Collections.Generic;

namespace Summatieve3
{
    public class Stap
    {
        public string Destination { get; }
        public SortedList<int,Stap> ConnectedStappen = new(); // PriorityQueue weight,stap

        public Stap(string _name)
        {
            Destination = _name;
        }
        public void AddConnectedStap((int, Stap) _addedStap)
        {
            ConnectedStappen.Add(_addedStap.Item1,_addedStap.Item2);
        }
        
        public virtual int GetCost()
        {
            return 0;
        }


        public virtual void SetCostOfSelf(int _cost)
        {

        }
    }
}
