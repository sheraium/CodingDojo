using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHand
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void S2()
        {
            var card = new Card("s2");
            Assert.AreEqual(SuitType.Spade, card.Suit);
            Assert.AreEqual(2, card.Number);
        }

        [TestMethod]
        public void DJ()
        {
            var card = new Card("dj");
            Assert.AreEqual(SuitType.Diamond, card.Suit);
            Assert.AreEqual(11, card.Number);
        }

        [TestMethod]
        public void CQ()
        {
            var card = new Card("cq");
            Assert.AreEqual(SuitType.Club, card.Suit);
            Assert.AreEqual(12, card.Number);
        }

        [TestMethod]
        public void HK()
        {
            var card = new Card("hk");
            Assert.AreEqual(SuitType.Heart, card.Suit);
            Assert.AreEqual(13, card.Number);
        }
    }
}