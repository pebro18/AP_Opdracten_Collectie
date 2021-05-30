using System.Collections.Generic;

namespace AR_Opdracten_Collectie.Summatieve_2
{
    public class Node
    {
        public string Name;
        public List<Node> ConnectingNodesList = new();

        public Node(string name)
        {
            Name = name;
        }

        public void AddNodeToList(Node _node)
        {
            ConnectingNodesList.Add(_node);
        }

        public Node GotoConnectingNode(string GoToNodeName)
        {
            Node FoundNode = ConnectingNodesList.Find(x => x.Name == GoToNodeName);

            if (FoundNode != null)
            {
                return FoundNode;
            }
            return null;
        }
    }
}
