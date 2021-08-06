using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WelcomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            ForLoop forLoop = new ForLoop();
            forLoop.WhileLoop();
            forLoop.ForEachLoop();
            forLoop.ForEachLoopString();
            forLoop.ForEachLoopChar();
        }
    }
}
