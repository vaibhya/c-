using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcLib;


namespace UnitTestCalc
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CheckingNo2isEven()
        {
            Calculator cal = new Calculator();
            bool expected = true;
            int inputVal = 2;

            bool actual = cal.CheckEven(inputVal);

            Assert.AreEqual(expected, actual);
        }
        public void CheckingNegative2NoisEven()
        {
            Calculator calc = new Calculator();
            bool expected = true;
            int inputVal = -2;

            bool actual = calc.CheckEven(inputVal);

            Assert.AreEqual(expected, actual);
        }
    }
}
