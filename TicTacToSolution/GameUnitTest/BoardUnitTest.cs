using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TicTacToGameDll;

namespace GameUnitTest
{
    [TestClass]
    public class BoardUnitTest
    {
        [TestMethod]
        public void Test_Set_Board_Size()
        {
            int expectedSize = 9;

            Board board = new Board(3);
            List<Cell> checkBoard = board.GetBoardList;
            int actualSize = checkBoard.Count;
            Assert.AreEqual(actualSize, expectedSize);
        }
        [TestMethod]
        public void Test_Mark_Cell_Method_for_X()
        {
            Mark expectedMark = Mark.X;
            Board board = new Board(3);
            board.MarkCell(0, Mark.X);
            Mark actualMark = board.GetMarkValue(0);

            Assert.AreEqual(expectedMark, actualMark);
        }
        [TestMethod]
        public void Test_Mark_Cell_Method_for_O()
        {
            Mark expectedMark = Mark.O;
            Board board = new Board(3);
            board.MarkCell(0, Mark.O);
            Mark actualMark = board.GetMarkValue(0);

            Assert.AreEqual(expectedMark, actualMark);
        }
        [TestMethod]
        public void Test_If_Board_Full()
        {
            bool expectedResult = true;
            Board board = new Board(3);
            for(int i = 0; i < 3 * 3; i++)
            {
                board.MarkCell(i, Mark.X);
            }
            Assert.AreEqual(expectedResult, board.IsBoardFull());

        }
    }
}
