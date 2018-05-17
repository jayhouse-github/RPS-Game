namespace Rock_Paper_Scissor.Interfaces
{
    public interface IGameResolver
    {
        int GetWinner(IPlayer player1, IPlayer player2);
    }
}
