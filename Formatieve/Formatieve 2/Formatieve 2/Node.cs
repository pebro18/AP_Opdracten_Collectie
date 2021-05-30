namespace AR_Opdracten_Collectie.Formatieve_2
{
    class Node
    {
        public string Name;
        public Node NodeA { set; get; }
        public Node NodeB { set; get; }

        public Node(string name)
        {
            Name = name;
        }

        public Node GotoConnectingNode(char GoTo)
        {
            return GoTo switch
            {
                'A' => NodeA,
                'B' => NodeB,
                _ => null,
            };

        }

    }

}
