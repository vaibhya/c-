using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalcLib;

namespace CalcConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Boolean result = calculator.CheckEven(3);
            Console.WriteLine(result);
            calculator.PrintSomething();
        }
    }
}
