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
    }

    public enum SuitType
    {
        Spade
    }
}