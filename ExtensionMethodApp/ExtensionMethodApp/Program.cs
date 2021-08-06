using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodApp.Extensions;

namespace ExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "vaibhav";
            Console.WriteLine(name.Foo());

            String completeName = "vaibhav pandurang kamble";
            Console.WriteLine(completeName.ToSnackCase());
        }
    }
}
