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
            foreach (var node in StateMachiene.NodeList)
            {
                Console.WriteLine($"Node {node.Name}: geef aan in nummers waaraan de node gaat verbinden en gebruik kommas om andere nummer aan te geven");
                string InputString = Console.ReadLine();
                string[] Numbers = InputString.Split(',');

                List<Node> LinkingToNodes = new();
                foreach (var number in Numbers)
                {
                    Node FoundNode = StateMachiene.NodeList.Find(x => x.Name == number);
                    LinkingToNodes.Add(FoundNode);
                }

                StateMachiene.LinkNodeToOtherNodes(node, LinkingToNodes.ToArray());
            }

            Console.WriteLine("Voer in Nummers met kommas tussen");
            string InputCommands = Console.ReadLine();
            string[] Commands = InputCommands.Split(',');
            StateMachiene.GoToNextNode(Commands);

            foreach (var Node in StateMachiene.NodeHistory)
            {
                Console.WriteLine(Node.Name);
            }
        }

    }
}
