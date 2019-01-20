using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHand
{
    [TestClass]
    public class PokerGameTest
    {
        [TestMethod]
        public void HighCard()
        {
            PokerGame pokerGame = new PokerGame("Cindy", "Winnie");
            var actual = pokerGame.WhoWins("s2,h3,d5,c6,s8", "s3,h4,d6,c7,s9");
            Assert.AreEqual("Winnie Win, Kind: High Card", actual);
        }
    }

    public enum SuitType
    {
        Spade
    }
}