using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo_PokerHand
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void S9()
        {
            var card = new Card("s", "9");
            Assert.AreEqual(SuitType.Spade, card.Suit);
            Assert.AreEqual(9, card.Number);
        }

        [TestMethod]
        public void DJ()
        {
            var card = new Card("D", "J");
            Assert.AreEqual(SuitType.Diamond, card.Suit);
            Assert.AreEqual(11, card.Number);
        }
    }

    public enum SuitType
    {
        Spade,
        Diamond
    }
}