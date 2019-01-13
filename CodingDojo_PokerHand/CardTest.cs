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

        [TestMethod]
        public void CQ()
        {
            var card = new Card("C", "Q");
            Assert.AreEqual(SuitType.Club, card.Suit);
            Assert.AreEqual(12, card.Number);
        }

        [TestMethod]
        public void HK()
        {
            var card = new Card("H", "K");
            Assert.AreEqual(SuitType.Heart, card.Suit);
            Assert.AreEqual(13, card.Number);
        }

        [TestMethod]
        public void HA()
        {
            var card = new Card("H", "A");
            Assert.AreEqual(SuitType.Heart, card.Suit);
            Assert.AreEqual(1, card.Number);
        }
    }

    public enum SuitType
    {
        Spade,
        Diamond,
        Club,
        Heart
    }
}