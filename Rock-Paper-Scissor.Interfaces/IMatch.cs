namespace Rock_Paper_Scissor.Interfaces
{
    public interface IMatch
    {
        int RoundsLeft { get; }
        int P1Score { get; }
        int P2Score { get; }
        IPlayer Player1 { get; }
        IPlayer Player2 { get; }

        void PlayRound();
    }
}
