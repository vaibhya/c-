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
        public String Allow
        {
            get { 
                return string.Join(", ", _allowns); }
        }
        public String generateString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(String item in _allowns) { sb.Append(item+" "); }
            return sb.ToString();

        }
        //public override string ToString()
        //{
         //   StringBuilder sb = new StringBuilder();
           // foreach (String item in _allowns) { sb.Append(item); }
            //return sb.ToString();
        //}
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
