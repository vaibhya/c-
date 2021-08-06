using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Point_App.ClassPointer;
using Point_App.StructurePointer;

namespace Point_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Using Point Class----");
            PointerClass p1 = new PointerClass(4, 5);
            p1.PrintDetails();
            PointerClass p2 = new PointerClass(6, 7);
            p1.UpdatePoint(p2);
            p1.PrintDetails();

            Console.WriteLine("---------Using Structure-------");
            PointerStructure pointStructure = new PointerStructure();
            Points point;
            point.point1 = 4;
            point.point2 = 5;
            
            pointStructure.PrintDetails(point);
            //updating points
            point.point1 = 6;
            point.point2 = 8;
            pointStructure.PrintDetails(point);
        }
    }
}
