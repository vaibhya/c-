using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employee_Data_Analyzer_App.Model;

namespace Employee_Data_Analyzer_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Load from Disk\n 2. Load from Web");
            String choice = Console.ReadLine();
            if (choice == "1")
            {
                DiskDataLoader data = new DiskDataLoader();
                
                PerformDataAnalysis(data);
            }
            if (choice == "2")
            {
                WebDataLoader data = new WebDataLoader();
                
                PerformDataAnalysis(data);
            }
               
  
        }

        private static void PerformDataAnalysis(IDataLoader data)
        {
            data.LoadData();
            DataAnalyzer dataAnalysis = new DataAnalyzer(data.EmployeeList);
            Employee emp = dataAnalysis.FindMaxSalary();
            Console.WriteLine("Max Salaried Employee Details: ");
            Console.WriteLine(emp);
            Console.WriteLine("Department Wise Employee Count");
            dataAnalysis.DisplayDeptEmpCount();
            Console.WriteLine("Designation wise Employee Count");
            dataAnalysis.DisplayDesignationEmpCount();
        }
    }
}
