using System.Collections.Generic;
using System.Linq;

namespace CodingDojo_PokerHand
{
    public class FlushMatcher : ICardTypeMatcher
    {
        public FlushMatcher()
        {
        }

        public bool IsMatch(List<Card> cards)
        {
            return cards.GroupBy(c => c.Suit).Count() == 1;
        }

        public CardType CardType
        {
            get { return CardType.Flush; }
        }
    }

    public class StraightFlushMatcher : ICardTypeMatcher
    {
        public StraightFlushMatcher()
        {
        }

        public bool IsMatch(List<Card> cards)
        {
            return new FlushMatcher().IsMatch(cards) && IsStraight(cards);
        }

        public CardType CardType => CardType.StraightFlush;

        private static bool IsStraight(List<Card> cards)
        {
            var isStraight = cards.GroupBy(c => c.Number).Count() == 5 &&
                             cards.GroupBy(c => c.Number).Max(g => g.Key) -
                             cards.GroupBy(c => c.Number).Min(g => g.Key) == 4;
            return isStraight;
        }
    }
}