using System;

namespace AP_Opdracten_Collectie.Formatieve
{
    public class Klant
    {
        private string naam;
        private double kortingPercentage;

        public Klant(string nm)
        {
            naam = nm;
        }

        public void SetKorting(double kP)
        {
            kortingPercentage = kP;
        }

        public double GetKorting()
        {
            return kortingPercentage;
        }

        public string toString()
        {
            string Output = "";
            if (naam != null)
            {
                Output += String.Format("op de naam van: {0} (korting: {1} %)\n", naam, kortingPercentage);
            }

            return Output;
        }
    }
}
