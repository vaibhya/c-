using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP_Solution_APP.Model
{
    class Manager : IWork, IEat
    {
        public void StartEat()
        {
            Console.WriteLine("Start Eat Manager");
        }

        public void StartWork()
        {
            Console.WriteLine("Start Work Manager");
        }

        public void StopEat()
        {
            Console.WriteLine("Stop Eat Manager"); ;
        }

        public void StopWork()
        {
            Console.WriteLine("Stop Work Manager"); ;
        }
    }
}
