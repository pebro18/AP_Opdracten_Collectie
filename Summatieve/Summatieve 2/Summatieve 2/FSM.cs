using System;
using System.Collections.Generic;
using System.Linq;

namespace AR_Opdracten_Collectie.Summatieve_2
{
    public class FSM
    {
        List<Node> NodeList;
        List<Node> NodeHistory = new();

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

        public void LinkNodeToOtherNodes(Node TargetNode, int[] LinkingToNumber)
        {
            foreach (var number in LinkingToNumber)
            {
                Node Found = NodeList.Find(x => x.Name == number.ToString());
                if (Found != null)
                {
                    TargetNode.AddNodeToDict(number,Found);
                }
                else
                {
                    Console.WriteLine("Node bestaat niet in lijst");
                }
            }
        }

        public void StartNodeGen(int[] NodeNummer)
        {
            foreach (int nummer in NodeNummer)
            {
                Node _CurrentNode = NodeHistory.Last();
                Node _NewNode = _CurrentNode.GetConnectingNode(nummer);
                if (_NewNode == null)
                {
                    Console.WriteLine($"Node Error bij: {_CurrentNode.Name}");
                    return;
                }
                NodeHistory.Add(_NewNode);
            }

        }

        public List<Node> GetNodeListNodes()
        {
            return NodeList;
        }
        public List<Node> GetNodeHistoryNodes()
        {
            return NodeHistory;
        }


    }
}
