using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP_Solution_APP.Model
{
    class Robot : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Start Eat Manager");
        }

        public void StopWork()
        {
            Console.WriteLine("Stop Eat Manager");
        }
    }
}
