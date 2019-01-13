using System.Collections.Generic;

namespace CodingDojo_PokerHand
{
    public class CardJudge
    {
        private readonly List<ICardTypeMatcher> _cardTypeMatchers = new List<ICardTypeMatcher>
        {
            new StraightFlushMatcher(),
            new FourOfAKindMatcher(),
            new FlushMatcher(),
new StraightMatcher()
        };

        public CardJudge(List<Card> cards)
        {
            Judge(cards);
        }

        private void Judge(List<Card> cards)
        {
            foreach (var cardTypeMatcher in _cardTypeMatchers)
            {
                if (cardTypeMatcher.IsMatch(cards))
                {
                    CardType = cardTypeMatcher.CardType;
                    break;
                }
            }
            //if (new StraightFlushMatcher().IsMatch(cards))
            //    CardType = this.CardType.StraightFlush;
            //else if (new FourOfAKindMatcher().IsMatch(cards))
            //    CardType = this.CardType.FourOfAKind;
        }

        public CardType CardType { get; set; }
    }

    //internal class FlushMatcher : ICardTypeMatcher
    //{
    //    public bool IsMatch(List<Card> cards)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public CardType CardType => CardType.Flush;
    //}
}