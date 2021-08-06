using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegateApp
{
    class Program
    {
        delegate void DPrintMessage(String msg);
        static void Main(string[] args)
        {
            DPrintMessage msg;
            msg = PrintHello;
            msg("vaibhav");
            msg += PrintHello;
            msg += PrintGoodby;
            msg += PrintHello;
            msg("Vaibhav kamble");
        }

        public static void PrintSomething(int msg)
        {
            Console.WriteLine(msg);
            
        }
        public static void PrintHello(String msg)
        {
            Console.WriteLine(msg);
        }
        public static void PrintGoodby(String msg)
        {
            Console.WriteLine(msg);
        }
    }
}
