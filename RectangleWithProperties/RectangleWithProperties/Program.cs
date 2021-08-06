using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RectangleEncapApp.Model;


namespace RectangleWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20, 30);
            Console.WriteLine(rectangle.Height);
            int area = rectangle.CalculateArea();
            Console.WriteLine(area);
            rectangle.Height = 40;
            int area2 = rectangle.CalculateArea();
            Console.WriteLine(rectangle.Height);
            Console.WriteLine(area2);
        }
    }
}
