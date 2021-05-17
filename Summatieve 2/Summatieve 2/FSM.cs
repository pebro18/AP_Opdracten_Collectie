using System;
using System.Collections.Generic;
using System.Linq;

namespace AR_Opdracten_Collectie.Summatieve_2
{
    public class FSM
    {
        public List<Node> NodeList;
        public List<Node> NodeHistory = new();

        public FSM(int nodeAmount)
        {
            NodeList = GenerateNodes(nodeAmount);
            NodeHistory.Add(NodeList[0]);
        }
        List<Node> GenerateNodes(int amount)
        {
            List<Node> GenNodeList = new();

            for (int i = 0; i < amount; i++)
            {
                GenNodeList.Add(new Node($"{i}"));
            }
            return GenNodeList;
        }

        public void LinkNodeToOtherNodes(Node TargetNode, Node[] LinkingToNodes)
        {
            foreach (var node in LinkingToNodes)
            {
                if (NodeList.Contains(node))
                {
                    TargetNode.AddNodeToList(node);
                }
                else
                {
                    Console.WriteLine("Node bestaat niet in lijst");
                }
            }
        }

        public void GoToNextNode(string[] NodeNummer)
        {
            foreach (string nummer in NodeNummer)
            {
                Node _CurrentNode = NodeHistory.Last();
                Node _NewNode = _CurrentNode.GotoConnectingNode(nummer);
                if (_NewNode == null)
                {
                    Console.WriteLine($"Node Error bij: {_CurrentNode.Name}");
                    break;
                }
                NodeHistory.Add(_NewNode);
            }

        }
    }
}
