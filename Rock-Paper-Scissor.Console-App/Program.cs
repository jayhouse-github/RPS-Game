using System;
using Rock_Paper_Scissor.RepoFactory;

namespace Rock_Paper_Scissor.Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1Type = 0;
            int player2Type = 0;
            string winnerText = "";

            while(player1Type < 1 || player1Type > 3)
            {
                Console.WriteLine("Select player 1 type: 1. Human, 2. Random computer, 3. Tactical computer.");
                Int32.TryParse(Console.ReadLine(), out player1Type);
            }

            while (player2Type < 1 || player2Type > 3)
            {
                Console.WriteLine("Select player 2 type: 1. Human, 2. Random computer, 3. Tactical computer.");
                Int32.TryParse(Console.ReadLine(), out player2Type);
            }

            var player1 = Repos.GetPlayerClass(player1Type);
            var player2 = Repos.GetPlayerClass(player2Type);
            var gameResolver = Repos.GetGameResolverClass();

            //Ask user for number of rounds to enable change. Hardcoded to 3 as per spec.
            var match = Repos.GetMatchClass(3, player1, player2, gameResolver);

            while (match.RoundsLeft > 0)
            {
                match.PlayRound();
                Console.WriteLine($"Player 1 played : {match.Player1.LastMove}");
                Console.WriteLine($"Player 2 played : {match.Player2.LastMove}");
                Console.WriteLine("Press enter.");
                Console.ReadLine();
            }

            if (match.P1Score == match.P2Score)
                winnerText = "It's a draw";
            else if (match.P1Score > match.P2Score)
                winnerText = "Player 1 wins";
            else if (match.P1Score < match.P2Score)
                winnerText = "Player 2 wins";

            Console.WriteLine(winnerText);
            Console.ReadLine();
        }
    }
}
