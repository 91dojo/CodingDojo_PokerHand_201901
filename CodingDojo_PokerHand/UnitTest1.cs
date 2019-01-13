using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo_PokerHand
{
    [TestClass]
    public class PokerGameTest
    {
        [TestMethod]
        public void same_card()
        {
            var pokerGame = new PokerGame("", "");

            var actual = pokerGame.GetResult("s1,s2,s3,s4,s5", "s1,s2,s3,s4,s5");
            Assert.AreEqual("Draw, Kind: Straight Flush", actual);
        }

        [TestMethod]
        public void straightFlush_win_4OfAKind()
        {
            var pokerGame = new PokerGame("Cindy", "Winnie");

            var actual = pokerGame.GetResult("s1,s2,s3,s4,s5", "s1,h1,c1,d1,s5");
            Assert.AreEqual("Cindy Win, Kind: Straight Flush", actual);
        }
    }

    public class PokerGame
    {
        private readonly string _firstPlayer;
        private readonly string _secondPlayer;

        public PokerGame(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
        }

        public string GetResult(string card1, string card2)
        {
            GetCardOfList(card1);

            if (card1 == card2)
            {
                return "Draw, Kind: Straight Flush";
            }

            return "";
        }

        private void GetCardOfList(string card1)
        {
            throw new System.NotImplementedException();
        }
    }
}