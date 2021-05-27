using System;
using System.Collections.Generic;
using System.Linq;

namespace Summatieve3
{
    public class Reis : IComparable
    {
        public List<Stap> ReisLijst;

        public Reis(int _amountSteps,string _typeReis)
        {
            ReisLijst = GenerateStappen(_amountSteps,_typeReis);
        }
        private List<Stap> GenerateStappen(int _amountSteps, string _typeReis)
        {
            throw new NotImplementedException();
        }

        // used example for Dijkstra
        // https://www.programiz.com/dsa/dijkstra-algorithm
        public void CalculateAllPathsFromStart(Stap _start)
        {
            throw new NotImplementedException();
            List<Stap> VistitedStap = new();
            foreach (var stap in ReisLijst)
            {
                stap.SetCostOfSelf(int.MaxValue);
            }
            _start.SetCostOfSelf(0);


            foreach (var stap1 in ReisLijst)
            {

                
                foreach (var stap2 in ReisLijst)
                {

                }

            }
        }

        public Stap GetStepOfMinDistance(Stap _current,List<Stap> _visited)
        {
            throw new NotImplementedException();
            Stap Output;
            foreach (var Connected in _current.ConnectedStappen)
            {
                if (!_visited.Contains(Connected.Value))
                {
                    
                }
            }

            return Output;
        }

        public void LinkStapWithOthers(Stap _target, (int,Stap)[] _stappen)
        {
            foreach (var stap in _stappen)
            {
                _target.AddConnectedStap(stap);
            }
        }

        public int CompareTo(object _reisObj)
        {
            throw new NotImplementedException();
            Reis compareObj = (Reis)_reisObj;

            // niet dit maar vergelijkt kosten en reistijd en shit

        }

        public int GetReisCount()
        {
            return ReisLijst.Count();
        }


    }
}
