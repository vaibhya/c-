using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Polymorphism.Model
{
    class Developer : Employee
    {
        private Double _projectAllowns = 40;
        private Double _pa = 30;
        
        public Developer(int empId, String empName, Double basicSalary) : base(empId, empName, basicSalary) { }
        public override double CalculateCTC()
        {
            Double pAllownsCalculator = (BasicSalary * _projectAllowns) / 100;
            Double pACalculator = (BasicSalary * _pa) / 100;
            Allownses.Add("Project Allowns: " + pAllownsCalculator);
            Allownses.Add("PA: " + pACalculator);
            return pAllownsCalculator + pACalculator + BasicSalary;
        }
    }
}
