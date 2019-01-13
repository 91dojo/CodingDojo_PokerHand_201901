using System.Collections.Generic;

namespace CodingDojo_PokerHand
{
    internal class Card
    {
        private readonly string _suit;
        private readonly string _numbers;

        private Dictionary<string, int> _lookNumber = new Dictionary<string, int>()
        {
            {"J",11},
            {"Q",12},
            {"K",13},
            {"A",1},
        };

        private Dictionary<string, SuitType> _lookupSuitType = new Dictionary<string, SuitType>
        {
            {"S", SuitType.Spade },
            {"D", SuitType.Diamond },
            {"C", SuitType.Club },
            {"H", SuitType.Heart },
        };

        public Card(string suit, string numbers)
        {
            _suit = suit.ToUpper();
            _numbers = numbers.ToUpper();
        }

        public SuitType Suit
        {
            get
            {
                return _lookupSuitType[_suit];
            }
        }

        public int Number
        {
            get
            {
                if (_lookNumber.ContainsKey(_numbers))
                {
                    return _lookNumber[_numbers];
                }
                return int.Parse(_numbers);
            }
        }
    }
}