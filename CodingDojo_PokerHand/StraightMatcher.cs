using System.Collections.Generic;
using System.Linq;

namespace CodingDojo_PokerHand
{
    public class StraightMatcher : ICardTypeMatcher
    {
        public StraightMatcher()
        {
        }

        public bool IsMatch(List<Card> cards)
        {
            var isStraight = cards.GroupBy(c => c.Number).Count() == 5 &&
                             cards.GroupBy(c => c.Number).Max(g => g.Key) -
                             cards.GroupBy(c => c.Number).Min(g => g.Key) == 4;
            return isStraight;
        }

        public CardType CardType => CardType.Straight;
    }
}