using System.Collections.Generic;
using System.Linq;

namespace CodingDojo_PokerHand
{
    public class CardJudge
    {
        public CardJudge(List<Card> cards)
        {
            Judge(cards);
        }

        private void Judge(List<Card> cards)
        {
            var isFlush = cards.GroupBy(c => c.Suit).Count() == 1;
            var groupByNumber = cards.GroupBy(c => c.Number);
            var isStraight = groupByNumber.Count() == 5 && groupByNumber.Max(g => g.Key) - groupByNumber.Min(g => g.Key) == 4;
            var isFourOfaKind = cards.GroupBy(c => c.Number).Any(x => x.Count() == 4);

            if (isFlush && isStraight)
                CartType = CartType.StraightFlush;
            else if (isFourOfaKind)
                CartType = CartType.FourOfAKind;
        }

        public CartType CartType { get; set; }
    }
}