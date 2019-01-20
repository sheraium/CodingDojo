namespace PokerHand
{
    public class PokerGame
    {
        private readonly string _firstPlayer;
        private readonly string _secondPlayer;

        public PokerGame(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
        }

        public string WhoWins(string firstPlayerCards, string secondPlayerCards)
        {
            throw new System.NotImplementedException();
        }
    }
}