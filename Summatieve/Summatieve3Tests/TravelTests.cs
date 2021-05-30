using Microsoft.VisualStudio.TestTools.UnitTesting;
using Summatieve3;

namespace Summatieve3Tests
{
    [TestClass]
    public class TravelTests
    {
        [TestMethod]
        public void TestGeneration()
        {
            Reis Travel = new(30, "Trein");
            Assert.AreEqual(30, Travel.GetReisCount());
        }
        [TestMethod]
        public void TestCalculateAllPathsFromStart()
        {
            Reis Travel = new(5, "Auto");
            (int, Stap)[] One = new[]{ (1,Travel.ReisLijst[1]),
                                        ( 4,Travel.ReisLijst[2])};
            Travel.LinkStapWithOthers(Travel.ReisLijst[0], One);
            (int, Stap)[] Two = new[]{ (1,Travel.ReisLijst[0]),
                                        ( 2,Travel.ReisLijst[2])};
            Travel.LinkStapWithOthers(Travel.ReisLijst[1], Two);
            (int,Stap)[] Three = new[]{ (4,Travel.ReisLijst[0]),
                                        ( 2,Travel.ReisLijst[1])};
            Travel.LinkStapWithOthers(Travel.ReisLijst[2], Three);
            Travel.CalculateAllPathsFromStart(Travel.ReisLijst[0]);
            Assert.AreEqual(0, Travel.ReisLijst[0].GetCost());
            Assert.AreEqual(1,Travel.ReisLijst[1].GetCost());
            Assert.AreEqual(5, Travel.ReisLijst[2].GetCost());
        }
    }
}
