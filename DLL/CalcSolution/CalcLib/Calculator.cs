using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CalcLib
{
    public class Calculator
    {
        public Boolean CheckEven(int no)
        {
            if (no % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public void PrintSomething()
        {
            Console.WriteLine("printing....");
        }
    }
}
