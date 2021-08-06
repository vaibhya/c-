using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISP_Solution_APP.Model;

namespace ISP_Solution_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            PerformWorkActivity(manager);
            PerformEatActivity(manager);
            Robot robot = new Robot();
            PerformWorkActivity(robot);
        }

        private static void PerformEatActivity(IEat manager)
        {
            manager.StartEat();
            manager.StopEat();
        }

        private static void PerformWorkActivity(IWork manager)
        {
            manager.StartWork();
            manager.StopWork();
        }

    }
}
