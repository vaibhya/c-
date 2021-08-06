using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<String> names = args;

            //immediate
            var longNamesImmediateE = names.Where(n => n.Length > 5).ToArray();
            foreach(var name in longNamesImmediateE)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----");
            //defered
            var longNames = names.Where(n => n.Length > 5);

            var namesInAssending = names.OrderBy(n => n);
            
            var namesWithVowels = names.Where(n => n.ToLower()
                                        .Contains("i") || n.ToLower()
                                        .Contains("e") || n.ToLower()
                                        .Contains("o") || n.ToLower()
                                        .Contains("a") || n.ToLower()
                                        .Contains("u"));

            var firstFourChar = names.Select(a=>a.Substring(0,4));

            PrintIEnumerator(longNames);
            PrintIEnumerator(namesInAssending);
            PrintIEnumerator(namesWithVowels);
            PrintIEnumerator(firstFourChar);
        }

        private static void PrintIEnumerator(IEnumerable<string> longNames)
        {
            foreach (String name in longNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
