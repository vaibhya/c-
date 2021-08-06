using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp.Extensions
{
    static class StringExtensions
    {
        public static String Foo(this String str)
        {
            return str;
        }
        public static String ToSnackCase(this String str)
        {
            String result = "";
            for (int i= 0;i < str.Length; i++)
            {
                char ch = str[i];
                if(Char.IsWhiteSpace(ch))
                {
                    result += "_";
                    continue;
                }
                
                 result += str[i];
                
            }
            return result;
        }
    }
}
