using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Opdracten_Collectie.Summatieve_2
{
    class Summatieve2Main
    {
        static void Main()
        {
            Console.WriteLine("Hoeveel nodes wil je genereren");
            int Amount = Int32.Parse(Console.ReadLine());
            FSM StateMachiene = new(Amount);
            foreach (var node in StateMachiene.NodeList)
            {
                Console.WriteLine($"{node.Name}: geef aan in nummers waaraan de node gaat verbinden");
            }

        }

    }
}
