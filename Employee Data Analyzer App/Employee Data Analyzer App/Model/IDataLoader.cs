using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Data_Analyzer_App.Model
{
    interface IDataLoader
    {
        void LoadData();
        List<Employee> EmployeeList { get; }
    }
}
