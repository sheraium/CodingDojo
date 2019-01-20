namespace PokerHand
{
    public class Card
    {
        public Card(string cardCode)
        {
            cardCode = cardCode.ToUpper();
            var suit = cardCode.Substring(0, 1);
            if (suit == "S")
            {
                Suit = SuitType.Spade;
            }
            Number = int.Parse(cardCode.Substring(1));
        }

        public SuitType Suit { get; }
        public int Number { get; }
    }
}