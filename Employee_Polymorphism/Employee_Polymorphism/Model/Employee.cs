using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Polymorphism.Model
{
    abstract class Employee
    {
        private int _empId;
        private String _empName;
        protected Double _basicSalary;
        protected List<String> _allowns = new List<string>();
        public Employee(int empId, String empName, Double basicSalary)
        {
            _empId = empId;
            _empName = empName;
            _basicSalary = basicSalary;
        }
        public abstract Double CalculateCTC();

        public List<String> Allownses
        {
            get { return _allowns; }
            
        }
        public int EmpId
        {
            get { return _empId; }
            
        }
        public String EmpName
        {
            get { return _empName; }
            
        }
        public Double BasicSalary
        {
            get { return _basicSalary; }
        }
    }
}
