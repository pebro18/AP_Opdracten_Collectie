namespace AP_Opdracten_Collectie.Formatieve
{

    public class AutoHuur
    {
        int aantalDagen;
        Klant huurder;
        Auto gehuurdeAuto;

        public AutoHuur() { }

        public void SetAantalDagen(int aD)
        {
            aantalDagen = aD;
        }

        public void SetGehuurdeAuto(Auto gA)
        {
            gehuurdeAuto = gA;
        }

        public Auto GetGehuurdeAuto()
        {
            return gehuurdeAuto;
        }

        public void SetHuurder(Klant k)
        {
            huurder = k;
        }

        public Klant GetHuurder()
        {
            return huurder;
        }

        double TotaalPrijs()
        {
            if (huurder != null && gehuurdeAuto != null)
            {
                return (gehuurdeAuto.GetPrijsPerDag() * aantalDagen) * (1 - huurder.GetKorting() / 100);
            }
            else
            {
                return 0.0;
            }
        }

        public string toString()
        {
            string Output = "";
            if (gehuurdeAuto != null)
            {
                Output += gehuurdeAuto.toString();
            }
            else
            {
                Output += "er is geen auto bekend\n";
            }
            if (GetHuurder() != null)
            {
                Output += huurder.toString();
            }
            else
            {
                Output += "er is huurder bekend\n";
            }
            Output += string.Format("aantal dagen: {0} en dat kost {1}", aantalDagen, TotaalPrijs());

            return Output;
        }
    }
}
