using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorEventApp.CalculatorBackend
{
    public delegate void MathCalculation(int number,String activity);
    public class Calculator
    {
        private int _n1;
        private int _n2;
        public Calculator(int n1,int n2)
        {
            _n1 = n1;
            _n2 = n2;
        }
        public event MathCalculation Activity;
        public void AddNumbers()
        {
            if (Activity != null)
            {
                Activity(_n1+_n2,"Addition");
                //Console.WriteLine(_n1 + _n2);
            }
            
        }
        public void SubtractNumber()
        {
            if (Activity != null)
            {
                Activity(_n1 - _n2,"Substraction");
                //Console.WriteLine();
            }
        }
        public void Multiplication()
        {
            if (Activity != null)
            {
                Activity(_n1 * _n2,"Multiplication");
                //Console.WriteLine(_n1 * _n2);
            }
        }
    }
}
