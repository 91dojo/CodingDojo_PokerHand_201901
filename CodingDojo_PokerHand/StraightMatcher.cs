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
            var isCardAllDifferent = cards.GroupBy(c => c.Number).Count() == 5;
            var numbers = cards.Select(c => c.Number).ToList();
            var isStraight = isCardAllDifferent &&
                             numbers.Max() -
                             numbers.Min() == 4;
            if (!isStraight)
            {
                if (numbers.Any(c => c == 1))
                {
                    var newNumbers = numbers.Select(x =>
                    {
                        if (x == 1)
                        {
                            return 14;
                        }

                        return x;
                    });

                    isStraight = isCardAllDifferent &&
                                 newNumbers.Max() -
                                 newNumbers.Min() == 4;
                }
            }

            return isStraight;
        }

        public CardType CardType => CardType.Straight;
    }
}