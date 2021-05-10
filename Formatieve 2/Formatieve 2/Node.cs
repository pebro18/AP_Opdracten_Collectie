namespace AR_Opdracten_Collectie.Formatieve_2
{
    class Node
    {
        public string name;
        public Node NodeA { set; get; }
        public Node NodeB { set; get; }

        public Node(string name)
        {
            this.name = name;
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
