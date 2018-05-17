using Rock_Paper_Scissor.Interfaces;

namespace Rock_Paper_Scissor.Logic
{
    public class Match : IMatch
    {
        int _roundsLeft;
        int _p1Score;
        int _p2Score;
        IPlayer _player1;
        IPlayer _player2;
        IGameResolver _gameResolver;

        public int RoundsLeft => _roundsLeft;
        public int P1Score => _p1Score;
        public int P2Score => _p2Score;
        public IPlayer Player1 => _player1;
        public IPlayer Player2 => _player2;

        public Match (int numberOfRounds, IPlayer p1, IPlayer p2, IGameResolver gameResolver)
        {
            _roundsLeft = numberOfRounds;
            _player1 = p1;
            _player2 = p2;
            _gameResolver = gameResolver;
        }

        public void PlayRound()
        {
            int winner = _gameResolver.GetWinner(_player1, _player2);
            _roundsLeft--;

            if (winner == 1)
                _p1Score++;
            else if (winner == 2)
                _p2Score++;
        }
    }
}

