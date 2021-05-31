using System;
using System.Collections.Generic;

namespace AR_Opdracten_Collectie.Summatieve_2
{
    class Summatieve2Main
    {
        static void Main()
        {
            Console.WriteLine("Hoeveel nodes wil je genereren");
            int Amount = Int32.Parse(Console.ReadLine());
            FSM StateMachiene = new(Amount);
            foreach (var node in StateMachiene.GetNodeListNodes())
            {
                Console.WriteLine($"Node {node.Name}: geef aan in nummers waaraan de node gaat verbinden en gebruik kommas om andere nummer aan te geven");
                string InputString = Console.ReadLine();
                string[] NumbersString = InputString.Split(',');
                int[] Numbers = Array.ConvertAll(NumbersString, int.Parse);
                StateMachiene.LinkNodeToOtherNodes(node, Numbers);
            }

            Console.WriteLine("Voer in Nummers met kommas tussen");
            string InputCommands = Console.ReadLine();
            string[] Commands = InputCommands.Split(',');
            int[] ParsedCommands = Array.ConvertAll(Commands, int.Parse);
            StateMachiene.StartNodeGen(ParsedCommands);

            foreach (var Node in StateMachiene.GetNodeHistoryNodes())
            {
                Console.WriteLine(Node.Name);
            }
        }

    }
}
