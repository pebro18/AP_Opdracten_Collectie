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

        public void AddNodeToList(int _key, Node _node)
        {
            ConnectingNodesList.Add(_key, _node);
        }

        public Node GotoConnectingNode(int GoToNodeKey)
        {
            if (ConnectingNodesList.ContainsKey(GoToNodeKey))
            {
                return ConnectingNodesList[GoToNodeKey]; ;
            }
            return null;
        }
        public int GetCount()
        {
            return ConnectingNodesList.Count;
        }
    }
}
