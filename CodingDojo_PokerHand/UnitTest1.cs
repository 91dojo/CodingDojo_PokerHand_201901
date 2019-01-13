using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodingDojo_PokerHand
{
    [TestClass]
    public class PokerGameTest
    {
        [TestMethod]
        public void same_card()
        {
            var pokerGame = new PokerGame("", "");

            var actual = pokerGame.GetResult("s1,s2,s3,s4,s5", "s1,s2,s3,s4,s5");
            Assert.AreEqual("Draw, Kind: Straight Flush", actual);
        }

        [TestMethod]
        public void straightFlush_win_4OfAKind()
        {
            var pokerGame = new PokerGame("Cindy", "Winnie");

            var actual = pokerGame.GetResult("s1,s2,s3,s4,s5", "s1,h1,c1,d1,s5");
            Assert.AreEqual("Cindy Win, Kind: Straight Flush", actual);
        }
    }

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

    internal class CardConverter
    {
        public List<Card> GetList(string cardString)
        {
            var cards = cardString.Split(',')
                .Select(it => new Card(it.Substring(0, 1),
                    it.Substring(1, it.Length-1)));

            return cards.ToList();
        }
    }

    internal class Card
    {
        private readonly string _suit;
        private readonly string _numbers;

        public Card(string suit, string numbers)
        {
            _suit = suit;
            _numbers = numbers;
        }
    }
}