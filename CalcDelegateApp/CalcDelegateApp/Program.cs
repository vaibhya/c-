using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcDelegateApp
{
    class Program
    {
        delegate void DMathOperations(int n1, int n2);
        static void Main(string[] args)
        {
            DMathOperations math;
            math = Add;
            math(2, 4);
            math += Substract;
            math += Add;
            math += Multiplication;
            math(5, 4);

        }

        public static void Add(int n1,int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        public static void Substract(int n1,int n2)
        {
            Console.WriteLine(n1 - n2);
        }
        public static void Multiplication(int n1,int n2)
        {
            Console.WriteLine(n1 * n2);
        }
    }
}
