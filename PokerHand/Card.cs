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
            if (suit == "D")
            {
                Suit = SuitType.Diamond;
            }
            if (cardCode.Substring(1) == "J")
            {
                Number = 11;
            }
            else
            {
                Number = int.Parse(cardCode.Substring(1));
            }
        }

        public SuitType Suit { get; }
        public int Number { get; }
    }
}