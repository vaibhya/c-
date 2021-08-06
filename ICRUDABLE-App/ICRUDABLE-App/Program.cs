using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICRUDABLE_App.Model;

namespace ICRUDABLE_App
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDb customerDb = new CustomerDb();
            PerformCrud(customerDb);
            DepartmentDb departmentDb = new DepartmentDb();
            PerformCrud(departmentDb);
        }

        private static void PerformCrud(ICrud db)
        {
            db.Create();
            db.Delete();
            db.Update();
            db.Read();
        }
    }
}
