using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RectangleEncapApp.Model;

namespace RectangleEncapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(10, 20);
            int area = rectangle1.CalculateArea();
            Console.WriteLine(area);
            rectangle1.SetBorder(BorderStyle.DOTTED);
            BorderStyle borderStyle = rectangle1.GetBorder();
            Console.WriteLine(borderStyle);
        }
    }
}
