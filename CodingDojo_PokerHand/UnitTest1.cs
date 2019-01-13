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

            var actual = pokerGame.GetResult();
            Assert.AreEqual("Draw", actual);
        }
    }

    public class PokerGame
    {
        public string GetResult()
        {
            return "Draw";
        }
    }
}