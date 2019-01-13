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
            if (IsFlush(cards) && IsStraight(cards))
                CartType = CartType.StraightFlush;
            else if (IsFourOfaKind(cards))
                CartType = CartType.FourOfAKind;
        }

        private static bool IsFourOfaKind(List<Card> cards)
        {
            var isFourOfaKind = cards.GroupBy(c => c.Number).Any(x => x.Count() == 4);
            return isFourOfaKind;
        }

        private static bool IsFlush(List<Card> cards)
        {
            return cards.GroupBy(c => c.Suit).Count() == 1;
        }

        private static bool IsStraight(List<Card> cards)
        {
            var isStraight = cards.GroupBy(c => c.Number).Count() == 5 &&
                             cards.GroupBy(c => c.Number).Max(g => g.Key) -
                             cards.GroupBy(c => c.Number).Min(g => g.Key) == 4;
            return isStraight;
        }

        public CartType CartType { get; set; }
    }
}