using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        }
    }

    public class CardJudge
    {
        public CardJudge(List<Card> cards)
        {
            throw new System.NotImplementedException();
        }
    }

    public enum CardType
    {
    }
}