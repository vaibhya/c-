using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Data_Analyzer_App.Model
{
    class CheckDublicate
    {
        public Boolean CheckDublicateValue(Employee checkEmp,List<Employee> employeeList)
        {
            foreach (Employee emp in employeeList)
            {
                if (emp.EmpId == checkEmp.EmpId)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
