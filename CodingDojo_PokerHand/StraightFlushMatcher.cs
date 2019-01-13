using System.Collections.Generic;

namespace CodingDojo_PokerHand
{
    public class StraightFlushMatcher : ICardTypeMatcher
    {
        public StraightFlushMatcher()
        {
        }

        public bool IsMatch(List<Card> cards)
        {
            return new FlushMatcher().IsMatch(cards) && new StraightMatcher().IsMatch(cards);
        }

        public CardType CardType => CardType.StraightFlush;
    }
}