namespace CodingDojo_PokerHand
{
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