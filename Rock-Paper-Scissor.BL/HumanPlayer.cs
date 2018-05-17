using System;
using Rock_Paper_Scissor.Interfaces;
using Rock_Paper_Scissor.Library;

namespace Rock_Paper_Scissor.Logic
{
    public class HumanPlayer : IPlayer
    {
        public Enums.Move LastMove { get; set; }

        public Enums.Move PlayNextMove()
        {         
            string humanInput = "-1";
            int humanInt;
            int moveDisplayCount = 1;

            Console.WriteLine("\nSelect Move");

            foreach(var move in Enum.GetValues(typeof(Enums.Move)))
            {
                Console.WriteLine($"{moveDisplayCount.ToString()}: {move}");
                moveDisplayCount++;
            }

            while(!InputIsValid(humanInput, out humanInt))
            {
                Console.WriteLine("Please enter a valid move number");
                humanInput = Console.ReadLine();
            }

            LastMove = (Enums.Move)humanInt-1;

            return LastMove;
        }

        private bool InputIsValid(string input, out int returnInt)
        {
            var noOfValidMoves = Enum.GetValues(typeof(Enums.Move)).Length;

            if(!Int32.TryParse(input, out int intValue))
            {
                returnInt = intValue;
                return false;
            }

            if(intValue < 1 || intValue > noOfValidMoves)
            {
                returnInt = intValue;
                return false;
            }

            returnInt = intValue;
            return true;
        }
    }
}
