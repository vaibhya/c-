using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Data_Analyzer_App.Model
{
    class DataAnalyzer
    {
        private List<Employee> _empList;
        public DataAnalyzer(List<Employee> empList)
        {
            _empList = empList;
        }

        public Employee FindMaxSalary()
        {
            Double maxSalary=0;
            Employee maxSalaryEmp=null;
            foreach(Employee emp in _empList)
            {
                if (emp.Salary > maxSalary)
                {
                    maxSalary = emp.Salary;
                    maxSalaryEmp = emp;
                }
            }
            return maxSalaryEmp;
        }
        public void DisplayDeptEmpCount()
        {
            List<int> deptNo = new List<int>();
            foreach(Employee emp in _empList)
            {
                deptNo.Add(emp.DeptId);
            }
            foreach (var grp in deptNo.GroupBy(i => i))
            {
                Console.WriteLine("{0} : {1}", grp.Key, grp.Count());
            }
            
        }
        public void DisplayDesignationEmpCount()
        {
            List<String> designations = new List<string>();
            foreach (Employee emp in _empList)
            {
                designations.Add(emp.EmpDesignation);
            }
            foreach (var grp in designations.GroupBy(i => i))
            {
                Console.WriteLine("{0} : {1}", grp.Key, grp.Count());
            }
        }
    }
}
