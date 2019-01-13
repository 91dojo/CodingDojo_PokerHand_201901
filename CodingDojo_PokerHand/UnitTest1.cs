using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo_PokerHand
{
    [TestClass]
    public class PokerGameTest
    {
        [TestMethod]
        public void same_card()
        {
            var pokerGame = new PokerGame();

            var actual = pokerGame.GetResult("s1,s2,s3,s4,s5", "s1,s2,s3,s4,s5");
            Assert.AreEqual("Draw, Kind: Straight Flush", actual);
        }
    }

    public class PokerGame
    {
        public string GetResult(string card1, string card2)
        {
            if (card1 == card2)
            {
                return "Draw, Kind: Straight Flush";
            }

            return "";
        }
    }
}