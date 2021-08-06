using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Data_Analyzer_App.Model
{
    class DiskDataLoader : IDataLoader
    {
        
        private String _path = "F:\\.net\\c#\\Employee Data Analyzer App\\emp.txt";
        private String[] _lines;
        private List<Employee> _employeeList = new List<Employee>();
        public void LoadData()
        {
            _lines = System.IO.File.ReadAllLines(@_path);
            
            foreach(String line in _lines)
            {
                string[] empDetails = line.Split(new char[] { ','});
                //Type tp = Double.Parse(empDetails[5]).GetType();
                //Console.WriteLine(tp);
                RemoveNull(empDetails);

                Employee empData = new Employee(Convert.ToInt32(empDetails[0]), empDetails[1], empDetails[2], Convert.ToInt32(empDetails[3]),empDetails[4], Convert.ToDouble(empDetails[5]), Convert.ToDouble(empDetails[6]), Convert.ToInt32(empDetails[7]));
                //Console.WriteLine(empDetails[0]);
                Boolean valid = new CheckDublicate().CheckDublicateValue(empData, _employeeList);
                if (valid)
                {
                    _employeeList.Add(empData);
                }
                
            }
        }

        private void RemoveNull(string[] empDetails)
        {
            int count = 0;
            foreach(String value in empDetails)
            {
                String newValue= value.Replace("NULL", "0");
                empDetails[count] = newValue;
                count++;
            }
        }

        public List<Employee> EmployeeList
        {
            get { return _employeeList; }
        }
    }
}
