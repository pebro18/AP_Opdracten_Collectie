using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AR_Opdracten_Collectie.Formatieve_2
{
    class Formatieve2Main
    {
        static void Main()
        {
            Node Node0 = new("s0");
            Node Node1 = new("s1");
            Node Node2 = new("s2");
            Node Node3 = new("s3");

            Node0.NodeA = Node2;
            Node0.NodeB = Node1;
            Node1.NodeA = Node1;
            Node1.NodeB = Node2;
            Node2.NodeB = Node3;
            Node3.NodeA = Node3;
            Node3.NodeB = Node0;

            Console.WriteLine("Voer in Letter A of B");
            string commands = Console.ReadLine();

            List<Node> NodeHistory = new List<Node> { Node0 };
            foreach (char command in commands)
            {
                Node _currentNode = NodeHistory.Last();
                Node _newNode = _currentNode.GotoConnectingNode(command);
                if (_newNode == null)
                {
                    Console.WriteLine($"Node Error bij: {_currentNode}");
                    break;
                }      
                NodeHistory.Add(_newNode);
            }
            foreach (var item in NodeHistory)
            {
                Console.WriteLine(item.name);
            }
        }
    }

}
