using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employee_Polymorphism.Model;

namespace Employee_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1, "vaibhav", 3000);
            PrintEmpDetails(manager);
            Developer dev1 = new Developer(2, "atul", 4000);
            PrintEmpDetails(dev1);
            Analyst analyst1 = new Analyst(3, "sagar", 2000);
            PrintEmpDetails(analyst1);
        }

        private static void PrintEmpDetails(Employee employee)
        {
            
            Console.WriteLine("-------------");
            Console.WriteLine(employee.GetType().Name);
            Console.WriteLine("CTC: "+employee.CalculateCTC());
            foreach (String allowns in employee.Allownses)
            {
                Console.WriteLine(allowns);
            }
            
        }
    }
}
