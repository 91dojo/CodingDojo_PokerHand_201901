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
}