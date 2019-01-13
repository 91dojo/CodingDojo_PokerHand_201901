using System.Collections.Generic;

namespace CodingDojo_PokerHand
{
    public interface ICardTypeMatcher
    {
        bool IsMatch(List<Card> cards);
        CardType CardType { get;  }
    }
}