using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rock_Paper_Scissor.Interfaces;
using Rock_Paper_Scissor.Library;
using Rock_Paper_Scissor.Logic;

namespace Rock_Paper_Scissor.Tests
{
    [TestClass]
    public class GameResolverTests
    {
        class RockPlayer : IPlayer
        {
            public Enums.Move LastMove { get; set; }

            public Enums.Move PlayNextMove()
            {
                return Enums.Move.Rock;
            }
        }

        class PaperPlayer : IPlayer
        {
            public Enums.Move LastMove { get; set; }

            public Enums.Move PlayNextMove()
            {
                return Enums.Move.Paper;
            }
        }

        class ScissorPlayer : IPlayer
        {
            public Enums.Move LastMove { get; set; }

            public Enums.Move PlayNextMove()
            {
                return Enums.Move.Scissor;
            }
        }

        [TestMethod]
        public void RockBeatsScissor()
        {
            //Arrange
            IPlayer player1 = new RockPlayer();
            IPlayer player2 = new ScissorPlayer();
            IGameResolver gameResolver = new GameResolver();

            //Act
            int winner = gameResolver.GetWinner(player1, player2);

            //Assert
            Assert.AreEqual(1, winner);
        }

        [TestMethod]
        public void ScissorBeatsPaper()
        {
            //Arrange
            IPlayer player1 = new ScissorPlayer();
            IPlayer player2 = new PaperPlayer();
            IGameResolver gameResolver = new GameResolver();

            //Act
            int winner = gameResolver.GetWinner(player1, player2);

            //Assert
            Assert.AreEqual(1, winner);
        }

        [TestMethod]
        public void PaperBeatsRock()
        {
            //Arrange
            IPlayer player1 = new PaperPlayer();
            IPlayer player2 = new RockPlayer();
            IGameResolver gameResolver = new GameResolver();

            //Act
            int winner = gameResolver.GetWinner(player1, player2);

            //Assert
            Assert.AreEqual(1, winner);
        }
    }
}
