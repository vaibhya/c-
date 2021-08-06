using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAnnotationApp
{
    class Foo
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        [MyCustomAnnotation]
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        [MyCustomAnnotation]
        public void Method4()
        {
            Console.WriteLine("Method 4");
        }
    }
}
