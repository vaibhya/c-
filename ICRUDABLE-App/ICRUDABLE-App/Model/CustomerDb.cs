using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICRUDABLE_App.Model
{
    class CustomerDb : ICrud
    {
        public void Create()
        {
            Console.WriteLine("Creating CustomerDb");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting CustomerDb");
        }

        public void Read()
        {
            Console.WriteLine("Reading CustomerDb");
        }

        public void Update()
        {
            Console.WriteLine("Updating CustomerDb");
        }
    }
}
