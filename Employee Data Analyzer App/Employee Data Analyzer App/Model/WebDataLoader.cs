using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Employee_Data_Analyzer_App.Model
{
    class WebDataLoader : IDataLoader
    {
        private String _strContent;
        private String[] _lines;
        private List<Employee> _employeeList = new List<Employee>();
        public void LoadData()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.DefaultConnectionLimit = 9999;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            var webRequest = WebRequest.Create(@"https://swabhav-tech.firebaseapp.com/emp.txt");

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                _strContent = reader.ReadToEnd();
                _lines = _strContent.Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.None
                );
            }
            
            foreach(String line in _lines)
            {
                string[] empDetails = line.Split(new char[] { ',' });
                RemoveNull(empDetails);

                Employee empData = new Employee(Convert.ToInt32(empDetails[0]), empDetails[1], empDetails[2], Convert.ToInt32(empDetails[3]), empDetails[4], Convert.ToDouble(empDetails[5]), Convert.ToDouble(empDetails[6]), Convert.ToInt32(empDetails[7]));
                
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
            foreach (String value in empDetails)
            {
                String newValue = value.Replace("NULL", "0");
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
