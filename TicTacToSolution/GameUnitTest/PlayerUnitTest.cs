using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToGameDll;

namespace GameUnitTest
{
    [TestClass]
    public class PlayerUnitTest
    {
        [TestMethod]
        public void TestPlayerClassConstructure()
        {
            Player player = new Player("vaibhav", Mark.O);
            Mark expectedMark = Mark.O;
            String expectedPlayerName = "vaibhav";

            Mark actualMark = player.GetMark;
            String actualPlayerName = player.PlayerName;

            Assert.AreEqual(actualPlayerName, expectedPlayerName);
            Assert.AreEqual(actualMark, expectedMark);
        }
        [TestMethod]
        public void TestSetPlayerNameMethod()
        {
            Player player = new Player("vaibhav", Mark.O);
            player.SetPlayerName("atul");

            String expectedName = "atul";
            String actualName = player.PlayerName;

            Assert.AreEqual(expectedName, actualName);
        }
        [TestMethod]
        public void TestSetMarkMethod()
        {
            Player player = new Player("vaibhav", Mark.X);
            player.SetPlayerMark(Mark.O);
            Mark expectedMark = Mark.O;
            Mark actulaMark = player.GetMark;

            Assert.AreEqual(expectedMark, actulaMark);
        }
    }
}
