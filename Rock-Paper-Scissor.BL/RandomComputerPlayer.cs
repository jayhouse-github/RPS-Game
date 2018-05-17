using System;
using Rock_Paper_Scissor.Interfaces;
using Rock_Paper_Scissor.Library;

namespace Rock_Paper_Scissor.Logic
{
    public class RandomComputerPlayer : IPlayer
    {
        public Enums.Move LastMove { get; set; }

        public Enums.Move PlayNextMove()
        {
            var values = Enum.GetValues(typeof(Enums.Move));
            var randomMove = (Enums.Move)values.GetValue(new Random().Next(values.Length));
            LastMove = randomMove;

            return randomMove;
        }
    }
}
