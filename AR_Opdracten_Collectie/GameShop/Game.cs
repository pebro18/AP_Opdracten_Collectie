namespace AP_Opdracten_Collectie.Formatieve
{
    class Game
    {
        public string name;
        public int releaseyear;
        public double prijs;

        public Game(string nm, int dt, double pr)
        {
            name = nm;
            releaseyear = dt;
            prijs = pr;
        }
    }
}
