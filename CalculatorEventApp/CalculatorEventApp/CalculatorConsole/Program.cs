using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEventApp.CalculatorBackend;

namespace CalculatorEventApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(7,4);
            calc.Activity += PrintResult;
            calc.Activity += GeneratePdf;
            calc.AddNumbers();
            calc.SubtractNumber();
            calc.Multiplication();
            
        }
        public static void PrintResult(int number,String action)
        {
            Console.WriteLine(action+" is:"+number);
        }
        public static void GeneratePdf(int number,String action)
        {
            Console.WriteLine("Generating PDF for activity "+action );
        }
    }
    
}
