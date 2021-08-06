using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICRUDABLE_App.Model
{
    class DepartmentDb : ICrud
    {
        public void Create()
        {
            Console.WriteLine("Creating DepartmentDb");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting DepartmentDb");
        }

        public void Read()
        {
            Console.WriteLine("Reading DepartmentDb");
        }

        public void Update()
        {
            Console.WriteLine("Updating DepartmentDb");
        }
    }
}
