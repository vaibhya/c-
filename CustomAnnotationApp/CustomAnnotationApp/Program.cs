using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomAnnotationApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();
            DoReflection(foo);
        }

        private static void DoReflection(Foo foo)
        {
            Type obj = foo.GetType();
            MethodInfo[] info = obj.GetMethods();
            foreach(MethodInfo m in info)
            {
                bool isAnnotationPresent = Attribute.IsDefined(m,typeof(MyCustomAnnotation));
                if (isAnnotationPresent)
                {
                    Console.WriteLine(m);
                }
            }
        }
    }
}
