using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using AccountApp.Model;

namespace AccountReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "Vaibhav", 1000);
            Console.WriteLine(account.AccountDetails);
            DoReflection(account.GetType());
            DoReflection(typeof( Object));
            
        }

        private static void DoReflection(Type account)
        {
            System.Type type = account.GetType();
            
            
            MethodInfo[] arr = type.GetMethods();
            foreach(MethodInfo m in arr)
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}
