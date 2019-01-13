using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodingDojo_PokerHand
{
    [TestClass]
    public class CardJudgeTest
    {
        [TestMethod]
        public void straightFlush()
        {
            var cardJudge = new CardJudge(new List<Card>
            {
                new Card("S", "A"),
                new Card("S", "2"),
                new Card("S", "3"),
                new Card("S", "4"),
                new Card("S", "5")
            });
            Assert.AreEqual(CardType.StraightFlush, cardJudge.CardType);
        }

        [TestMethod]
        public void four_of_a_kind()
        {
            var cardJudge = new CardJudge(new List<Card>
            {
                new Card("S", "2"),
                new Card("S", "2"),
                new Card("S", "2"),
                new Card("S", "2"),
                new Card("S", "5")
            });
            Assert.AreEqual(CardType.FourOfAKind, cardJudge.CardType);
        }
    }

    public enum CardType
    {
        StraightFlush,
        FourOfAKind
    }
}