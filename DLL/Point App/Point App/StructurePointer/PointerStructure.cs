using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point_App.StructurePointer
{
    public struct Points
    {
        public int point1;
        public int point2;
    }
    class PointerStructure
    {
        
        public void PrintDetails(Points p)
        {
            Console.WriteLine(p.point1 + " , " + p.point2);
        }
        
    }
}
