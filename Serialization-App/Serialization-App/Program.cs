using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountApp.Model;
using Serialization_App.Model;

namespace Serialization_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account(1, "vaibhav");
            Serialize serialize = new Serialize();
            //serialize.SerializeAccount(account);

            Account account2 = serialize.DeserializeAccount();
            Console.WriteLine(account2);
        }
    }
}
