using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Polymorphism.Model
{
    class Analyst : Employee
    {
        private Double _perks=30;
        public Analyst(int empId,String empName,Double basicSalary) : base(empId, empName, basicSalary) { }
        public override double CalculateCTC()
        {
            Double perks = (BasicSalary * _perks) / 100;
            Allownses.Add("Perks: " + perks);
            return perks + BasicSalary;
        }
    }
}
