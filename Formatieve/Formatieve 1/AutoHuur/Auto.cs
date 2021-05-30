using System;

namespace AP_Opdracten_Collectie.Formatieve
{
    public class Auto
    {
        private string type;
        private double prijsPerDag;

        public Auto(string tp, double prPd)
        {
            type = tp;
            prijsPerDag = prPd;
        }

        public void SetPrijsPerDag(double prPd)
        {
            prijsPerDag = prPd;
        }

        public double GetPrijsPerDag()
        {
            return prijsPerDag;
        }

        public string toString()
        {
            string Output = "";
            if (type != null && prijsPerDag != 0)
            {
                Output += String.Format("autotype : {0} met prijs per dag: {1}\n", type, prijsPerDag);
            }

            return Output;
        }

    }
}
