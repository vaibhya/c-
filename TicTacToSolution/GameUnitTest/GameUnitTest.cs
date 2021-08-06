using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToGameDll;

namespace GameUnitTest
{
    [TestClass]
    public class GameUnitTest
    {
        [TestMethod]
        public void Check_current_playing_player()
        {
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(new Board(3));
            Player player1 = new Player("vaibhav", Mark.O);
            Player player2 = new Player("atul", Mark.X);
            Board board = new Board(3);
            Game game = new Game(resultAnalyzer, player1, player2, board);
            Player expectedPlayer = player1;

            Assert.AreEqual(expectedPlayer, game.GetCurrentPlayer());
        }
        [TestMethod]
        public void Check_switch_player_method()
        {
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(new Board(3));
            Player player1 = new Player("vaibhav", Mark.O);
            Player player2 = new Player("atul", Mark.X);
            Board board = new Board(3);
            Game game = new Game(resultAnalyzer, player1, player2, board);
            Player expectedPlayer = player2;

            game.SwitchPlayer();
            Assert.AreEqual(expectedPlayer, game.GetCurrentPlayer());
        }
    }
}
