using System.Collections.Generic;

namespace AR_Opdracten_Collectie.Summatieve_2
{
    public class Node
    {
        public string Name;
        Dictionary<int, Node> ConnectingNodesList = new();

        public Node(string name)
        {
            Name = name;
        }

        public void AddNodeToDict(int _key, Node _node)
        {
            ConnectingNodesList.Add(_key, _node);
        }

        public Node GetConnectingNode(int NodeKey)
        {
            if (ConnectingNodesList.ContainsKey(NodeKey))
            {
                return ConnectingNodesList[NodeKey]; ;
            }
            return null;
        }
        public int GetCount()
        {
            return ConnectingNodesList.Count;
        }
    }
}
