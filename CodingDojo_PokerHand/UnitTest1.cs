using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo_PokerHand
{
    [TestClass]
    public class PokerGameTest
    {
        private PokerGame _pokerGame = new PokerGame("Cindy", "Winnie");

        [TestMethod]
        public void same_card()
        {
            var actual = _pokerGame.GetResult("s1,s2,s3,s4,s5", "s1,s2,s3,s4,s5");
            Assert.AreEqual("Draw, Kind: Straight Flush", actual);
        }

        [TestMethod]
        public void straightFlush_win_4OfAKind()
        {
            var actual = _pokerGame.GetResult("s1,s2,s3,s4,s5", "s1,h1,c1,d1,s5");
            Assert.AreEqual("Cindy Win, Kind: Straight Flush", actual);
        }
    }
}