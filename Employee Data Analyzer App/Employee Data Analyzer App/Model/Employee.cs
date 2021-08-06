using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Data_Analyzer_App.Model
{
    class Employee
    {
        private int _empId;
        private String _empName;
        private String _empDesignation;
        private int _managerId;
        private Double _salary;
        private Double _comission;
        private int _deptId;
        private String _joiningDate;
        public Employee(int empId,String empName,String empDesignation,int managerId,String joiningDate,Double salary,Double comission,int deptId)
        {
            
            _empId = empId;
            _empName = empName;
            _empDesignation = empDesignation;
            _managerId = managerId;
            _salary = salary;
            _comission = comission;
            _deptId = deptId;
            _joiningDate = joiningDate;
        }
        public override string ToString()
        {
            return "EmpId: "+_empId+" EmpName: "+_empName+" empSalary: "+_salary;
        }
        public int EmpId
        {
            get { return _empId; }
        }
        public String EmpName
        {
            get { return _empName; }
        }
        public String EmpDesignation
        {
            get { return _empDesignation; }
        }
        public int ManagerId
        {
            get { return _managerId; }
        }
        public Double Salary
        {
            get { return _salary; }
        }
        public Double Comission
        {
            get { return _comission; }
        }
        public int DeptId
        {
            get { return _deptId; }
        }
    }
}
