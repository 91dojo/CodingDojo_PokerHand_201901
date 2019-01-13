using System.Collections.Generic;

namespace CodingDojo_PokerHand
{
    internal class Card
    {
        private readonly string _suit;
        private readonly string _numbers;

        public Card(string suit, string numbers)
        {
            _suit = suit.ToUpper();
            _numbers = numbers.ToUpper();
        }

        public SuitType Suit
        {
            get
            {
                var lookupSuitType = new Dictionary<string, SuitType>
                {
                    {"S", SuitType.Spade },
                    {"D", SuitType.Diamond },
                };
                return lookupSuitType[_suit];
            }
        }

        public int Number
        {
            get
            {
                var lookNumber = new Dictionary<string, int>()
                {
                    {"J",11},
                };
                if (lookNumber.ContainsKey(_numbers))
                {
                    return lookNumber[_numbers];
                }
                return int.Parse(_numbers);
            }
        }
    }
}