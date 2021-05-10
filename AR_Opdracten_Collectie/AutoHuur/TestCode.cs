using System;

namespace AP_Opdracten_Collectie.Formatieve
{
    class TestCode
    {
        static void Main()
        {
            AutoHuur ah1 = new();
            Console.WriteLine("Eerste autohuur: " + ah1.toString());

            Klant k = new("Mijnheer de Vries");
            k.SetKorting(10.0);
            ah1.SetHuurder(k);
            Console.WriteLine("Eerste autohuur: " + ah1.toString());

            Auto a1 = new("Peugeot 207", 50);
            ah1.SetGehuurdeAuto(a1);
            ah1.SetAantalDagen(4);
            Console.WriteLine("Eerste autohuur: " + ah1.toString());

            AutoHuur ah2 = new();
            Auto a2 = new("Ferrari", 3500);
            ah2.SetGehuurdeAuto(a2);
            ah2.SetHuurder(k);
            ah2.SetAantalDagen(1);
            Console.WriteLine("Tweede autohuur: " + ah2.toString());

            Console.WriteLine("Gehuurd: " + ah1.GetGehuurdeAuto());
            Console.WriteLine("Gehuurd: " + ah2.GetGehuurdeAuto());
        }
    }
}
