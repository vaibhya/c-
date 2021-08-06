using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point_App.ClassPointer
{
    class PointerClass
    {
        private int _point1, _point2;
        public PointerClass(int point1,int point2)
        {
            _point1 = point1;
            _point2 = point2;
        }
        public void UpdatePoint(PointerClass p1)
        {
            Console.WriteLine("Updating points");
            _point1 = p1._point1;
            _point2 = p1.Point2;
        }
        public void PrintDetails()
        {
            Console.WriteLine(_point1+" , "+_point2);
        }
        public int Point1
        {
            get { return _point1; }
        }
        public int Point2
        {
            get { return _point2; }
        }
    }
}
