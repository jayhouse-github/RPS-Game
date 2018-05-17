using Rock_Paper_Scissor.Interfaces;

namespace Rock_Paper_Scissor.Logic
{
    public class GameResolver : IGameResolver
    {
        public int GetWinner(IPlayer player1, IPlayer player2)
        {
            var p1Move = player1.PlayNextMove();
            var p2Move = player2.PlayNextMove();

            if (p1Move == p2Move)
                return 0;

            if (p1Move == Library.Enums.Move.Rock)
            {
                if (p2Move == Library.Enums.Move.Scissor)
                    return 1;
                else
                    return 2;
            }
            else if (p1Move == Library.Enums.Move.Paper)
            {
                if (p2Move == Library.Enums.Move.Rock)
                    return 1;
                else
                    return 2;
            }
            else
            {
                if (p2Move == Library.Enums.Move.Paper)
                    return 1;
                else
                    return 2;
            }
        }
    }
}
