using System.Collections.Generic;

namespace CodingDojo_PokerHand
{
    public class PokerGame
    {
        private string _firstPlayer;
        private string _secondPlayer;

        public PokerGame(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
        }

        public string GetResult(string card1, string card2)
        {
            List<Card> player1Cards = GetCardOfList(card1);
            List<Card> player2Cards = GetCardOfList(card2);

            var cardType = GetCardType(player1Cards);
            if (card1 != card2)
            {
                return "Cindy Win, Kind: Straight Flush";
            }

            return "Draw, Kind: Straight Flush";
        }

        private string GetCardType(List<Card> player1Cards)
        {
            return "Straight Flush";
        }

        private List<Card> GetCardOfList(string card1)
        {
            var card = new CardConverter();
            return card.GetList(card1);
        }
    }
}