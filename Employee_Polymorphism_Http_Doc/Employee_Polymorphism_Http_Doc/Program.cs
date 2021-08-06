using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employee_Polymorphism.Model;
using Employee_Polymorphism_Http_Doc.Model;

namespace Employee_Polymorphism_Http_Doc
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer(1, "vaibhav", 3000);
            Manager manager = new Manager(2, "atul", 4000);
            HtmlDoc html = new HtmlDoc();
            Console.WriteLine(html.SB);
            html.AddToHtml(developer);
            html.AddToHtml(manager);
            Console.WriteLine(html.SB);
            html.GenerateHtml();
        }
    }
}
