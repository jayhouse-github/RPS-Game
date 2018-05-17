using Rock_Paper_Scissor.Interfaces;
using Rock_Paper_Scissor.Library;

namespace Rock_Paper_Scissor.Logic
{
    public class TacticalComputerPlayer : IPlayer
    {
        public Enums.Move LastMove { get; set; }

        public Enums.Move PlayNextMove()
        {
            switch (LastMove)
            {
                case Enums.Move.Paper:
                    LastMove = Enums.Move.Scissor;
                    break;
                case Enums.Move.Rock:
                    LastMove = Enums.Move.Paper;
                    break;
                case Enums.Move.Scissor:
                    LastMove = Enums.Move.Rock;
                    break;
            }

            return LastMove;
        }
    }
}
