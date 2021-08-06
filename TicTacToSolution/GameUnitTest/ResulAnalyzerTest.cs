using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToGameDll;

namespace GameUnitTest
{
    [TestClass]
    public class ResulAnalyzerTest
    {
        [TestMethod]
        public void Check_expected_X_string_Size()
        {
            Board board = new Board(3);
            ResultAnalyzer resultAnalzer = new ResultAnalyzer(board);
            String expectedXStringSize = "XXX";

            String actualXStringSize = resultAnalzer.GetExpectedXString;

            Assert.AreEqual(expectedXStringSize, actualXStringSize);
        }

        [TestMethod]
        public void Check_expected_O_string_Size()
        {
            Board board = new Board(3);
            ResultAnalyzer resultAnalzer = new ResultAnalyzer(board);
            String expectedOStringSize = "OOO";

            String actualOStringSize = resultAnalzer.GetExpectedOString;

            Assert.AreEqual(expectedOStringSize, actualOStringSize);
        }
        [TestMethod]
        public void Check_Diagonal1_Winner_method()
        {
            Board board = new Board(3);
            ResultAnalyzer resultAnalzer = new ResultAnalyzer(board);
            Boolean expectedResult = true;
            
            board.MarkCell(0, Mark.X);
            board.MarkCell(4, Mark.X);
            board.MarkCell(8, Mark.X);
            
            
            Boolean actualResult = resultAnalzer.FindDiagonalWinner1();

            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void Check_Diagonal2_Winner_method()
        {
            Board board = new Board(3);
            ResultAnalyzer resultAnalzer = new ResultAnalyzer(board);
            Boolean expectedResult = true;

            board.MarkCell(2, Mark.X);
            board.MarkCell(4, Mark.X);
            board.MarkCell(6, Mark.X);

            Boolean actualResult = resultAnalzer.FindDiagonalWinner2();

            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void Check_Row_Winner_method()
        {
            Board board = new Board(3);
            ResultAnalyzer resultAnalzer = new ResultAnalyzer(board);
            Boolean expectedResult = true;

            board.MarkCell(0, Mark.X);
            board.MarkCell(1, Mark.X);
            board.MarkCell(2, Mark.X);

            Boolean actualResult = resultAnalzer.FindRowWinner();

            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void Check_Column_Winner_method()
        {
            Board board = new Board(3);
            ResultAnalyzer resultAnalzer = new ResultAnalyzer(board);
            Boolean expectedResult = true;

            board.MarkCell(0, Mark.X);
            board.MarkCell(3, Mark.X);
            board.MarkCell(6, Mark.X);

            Boolean actualResult = resultAnalzer.FindColumnWinner();

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
