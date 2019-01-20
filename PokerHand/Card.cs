using System.Collections.Generic;

namespace PokerHand
{
    public class Card
    {
        private Dictionary<string, SuitType> _suitLookup = new Dictionary<string, SuitType>
            {
                {"S",SuitType.Spade },
                {"D",SuitType.Diamond },
                {"C",SuitType.Club },
                {"H",SuitType.Heart },
            };

        private Dictionary<string, int> _numberLookup = new Dictionary<string, int>()
            {
                {"J",11 },
                {"Q",12 },
                {"K",13 },
            };

        public Card(string cardCode)
        {
            cardCode = cardCode.ToUpper();
            var suit = cardCode.Substring(0, 1);
            Suit = _suitLookup[suit];
            var number = cardCode.Substring(1);
            Number = _numberLookup.ContainsKey(number) ? _numberLookup[number] : int.Parse(number);
        }

        public SuitType Suit { get; }
        public int Number { get; }
    }
}