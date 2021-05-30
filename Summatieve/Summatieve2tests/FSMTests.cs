using Microsoft.VisualStudio.TestTools.UnitTesting;
using AR_Opdracten_Collectie.Summatieve_2;

namespace Summatieve2tests
{
    [TestClass]
    public class TestFSM
    {
        [TestMethod]
        public void TestFSMGeneration()
        {
            //Arrange
            const int GenerateAmount = 25;
            //Act
            FSM Machiene = new(GenerateAmount);
            //Assert
            Assert.AreEqual(GenerateAmount, Machiene.NodeList.Count);
        }

        [TestMethod]
        public void TestFSMIfNodeExistBeforeLinkingToIt()
        {
            //Arrange
            const int GenerateAmount = 3;
            FSM Machiene = new(GenerateAmount);

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[0], new int[] { 1 });
            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[1], new int[] { 2 });
            //Act
            // this should be an error
            Node ErrorNode = new("4");
            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[2], new int[] { 4 });

            //Assert
            Assert.AreEqual(0, Machiene.NodeList[2].GetCount());
        }

        [TestMethod]
        public void TestFSMTestConnections()
        {
            //Arrange
            const int GenerateAmount = 5;
            FSM Machiene = new(GenerateAmount);

            //Act

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[0], new int[] { 0, 1, 3 });

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[1], new int[] { 2 });

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[2], new int[]{1, 2, 3});

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[3], new int[] { 1, 4, 0 });

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[4], new int[] { 0, 1 });

            //Assert
            Assert.AreEqual(3, Machiene.NodeList[0].GetCount());
            Assert.AreEqual(1, Machiene.NodeList[1].GetCount());
            Assert.AreEqual(3, Machiene.NodeList[2].GetCount());
            Assert.AreEqual(3, Machiene.NodeList[3].GetCount());
            Assert.AreEqual(2, Machiene.NodeList[4].GetCount());
        }

        [TestMethod]
        public void TestFSMBreakWhenNodeConnectionDoesNotExist()
        {
            //Arrange
            const int GenerateAmount = 3;
            FSM Machiene = new(GenerateAmount);

            Node[] LinkArray1 = new[] { Machiene.NodeList[1] };
            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[0], new int[] { 1 });

            Node[] LinkArray2 = new[] { Machiene.NodeList[2] };
            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[1], new int[] { 2 });

            Node[] LinkArray3 = new[] { Machiene.NodeList[0] };
            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[2], new int[] { 3 });

            //Act
            int[] Commands = new[] { 1, 4 };
            Machiene.GoToNextNode(Commands);

            //Assert
            Node[] Expected = new[]
            {
                Machiene.NodeList[0],
                Machiene.NodeList[1]
            };

            Node[] Result = Machiene.NodeHistory.ToArray();
            Assert.IsTrue(CheckIfNodeArraysAreEqualInContent(Expected, Result));
        }

        [TestMethod]
        public void TestFSMNodeHistory()
        {
            //Arrange
            const int GenerateAmount = 5;
            FSM Machiene = new(GenerateAmount);

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[0], new int[] { 0, 1, 3 });

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[1], new int[] { 2 });

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[2], new int[] { 1, 2, 3 });

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[3], new int[] { 1, 4, 0 });

            Machiene.LinkNodeToOtherNodes(Machiene.NodeList[4], new int[] { 0, 1 });

            //Act
            int[] Commands = new[] { 1, 2, 3, 1, 2 };
            Machiene.GoToNextNode(Commands);

            //Assert
            Node[] Expected = new[]
            {
                Machiene.NodeList[0],
                Machiene.NodeList[1],
                Machiene.NodeList[2],
                Machiene.NodeList[3],
                Machiene.NodeList[1],
                Machiene.NodeList[2]
            };

            Node[] Result = Machiene.NodeHistory.ToArray();
            Assert.IsTrue(CheckIfNodeArraysAreEqualInContent(Expected, Result), "Node list not the same");
        }

        bool CheckIfNodeArraysAreEqualInContent(Node[] NodeArray1, Node[] NodeArray2)
        {
            if (NodeArray1.Length == NodeArray2.Length)
            {
                for (int i = 0; i < NodeArray1.Length; i++)
                {
                    if (NodeArray1[i] != NodeArray2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
