using System;
using Rock_Paper_Scissor.Logic;
using Rock_Paper_Scissor.Interfaces;

namespace Rock_Paper_Scissor.RepoFactory
{
    public static class Repos
    {
        public static IPlayer GetPlayerClass(int inType)
        {
            switch (inType)
            {
                case 1:
                    return new HumanPlayer();
                case 2:
                    return new RandomComputerPlayer();
                case 3:
                    return new TacticalComputerPlayer();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static IGameResolver GetGameResolverClass()
        {
            return new GameResolver();
        }

        public static IMatch GetMatchClass(int numberOfRounds, IPlayer p1, IPlayer p2, IGameResolver gameResolver)
        {
            return new Match(numberOfRounds, p1, p2, gameResolver);
        }
    }
}
