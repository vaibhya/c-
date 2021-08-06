using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToGameDll;

namespace GameUnitTest
{
    [TestClass]
    public class CellUnitTest
    {
        [TestMethod]
        public void TestEmptyMarkSet()
        {
            Cell cell = new Cell();
            Mark expectedMark = Mark.EMPTY;

            Mark actualMark = cell.GetMark;
            Assert.AreEqual(expectedMark, actualMark);
        }
        [TestMethod]
        public void TestSetMarkMethodForX()
        {
            Cell cell = new Cell();
            Mark expectedMark = Mark.X;

            cell.SetMark(Mark.X);
            Mark actualMark = cell.GetMark;
            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void TestSetMarkMethodForO()
        {
            Cell cell = new Cell();
            Mark expectedMark = Mark.O;

            cell.SetMark(Mark.O);
            Mark actualMark = cell.GetMark;
            Assert.AreEqual(expectedMark, actualMark);
        }

    }
}
