using System.Collections.Generic;
using System.Linq;

namespace CodingDojo_PokerHand
{
    public class FourOfAKindMatcher : ICardTypeMatcher
    {
        public FourOfAKindMatcher()
        {
        }

        public bool IsMatch(List<Card> cards)
        {
            return cards.GroupBy(c => c.Number).Any(x => x.Count() == 4);
        }

        public CardType CardType
        {
            get { return CardType.FourOfAKind; }
        }
    }
}