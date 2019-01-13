using System.Collections.Generic;
using System.Linq;

namespace CodingDojo_PokerHand
{
    internal class CardConverter
    {
        public List<Card> GetList(string cardString)
        {
            var cards = cardString.Split(',')
                .Select(it => new Card(it.Substring(0, 1),
                    it.Substring(1, it.Length - 1)));

            return cards.ToList();
        }
    }
}