using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Employee_Polymorphism_Http_Doc.Model
{
    class HtmlDoc
    {
        public HtmlDoc()
        {
            string fileName = Path.GetFullPath(@"F:\.net\c#\Employee_Polymorphism_Http_Doc\index.html");
            try
            {
                //if (File.Exists(fileName))
                //{
                 //   File.Delete(fileName);
                //}
                using (FileStream fs = File.Create(fileName))
                {
                      
                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                    fs.Write(author, 0, author.Length);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
