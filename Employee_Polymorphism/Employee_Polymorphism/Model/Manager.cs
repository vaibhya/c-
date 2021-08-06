using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Polymorphism.Model
{
    class Manager : Employee
    {
        private Double _hra = 50;
        private Double _ta = 40;
        
        public Manager(int empId,String empName,Double basicSalary) : base(empId, empName, basicSalary) { }
        public override Double CalculateCTC()
        {
           
            Double hraCal = (BasicSalary * _hra) / 100;
            Allownses.Add("HRA Allowns: " + hraCal);
            Double taCal = (BasicSalary * _ta) / 100;
            Allownses.Add("TA Allowns: " + taCal);
            Double ctc = hraCal + taCal + BasicSalary;
            
            return ctc;
        }
        
    }
}
