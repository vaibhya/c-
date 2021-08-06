using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Employee_Polymorphism.Model;

namespace Employee_Polymorphism_Http_Doc.Model
{
    class HtmlDoc
    {
        private String _fileName;
        private StringBuilder _sb = new StringBuilder();
        public HtmlDoc()
        {
            _fileName = Path.GetFullPath(@"F:\.net\c#\Employee_Polymorphism_Http_Doc\index.html");
            try
            {
                if (File.Exists(_fileName))
                {
                    File.Delete(_fileName);
                }
                using (FileStream fs = File.Create(_fileName))
                { 
                    Byte[] title = new UTF8Encoding(true).GetBytes("<h1>Employee Details</h1>");
                    fs.Write(title, 0, title.Length);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddToHtml(Employee emp)
        {
            _sb.AppendLine("<hr>");
            _sb.AppendLine("Emplyee Designation: "+emp.GetType().Name+"<br>");
            _sb.AppendLine("Employee Name: "+emp.EmpName + "<br>");
            _sb.AppendLine("Employee Id: "+emp.EmpId + "<br>");
            _sb.AppendLine("CTC:"+emp.CalculateCTC()+"<br>");
            _sb.AppendLine("Employee Allownses: <br>" + emp.generateString());
            
        }
        public String SB
        {
            get { return _sb.ToString(); }
        }
        public void GenerateHtml()
        {
            
            try
            {
                String newContent = SB;
                while (newContent != "exit")
                {
                    File.AppendAllText(_fileName, newContent + Environment.NewLine);
                    newContent = Console.ReadLine();
                }
                
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
