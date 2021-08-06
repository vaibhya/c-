using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqStudentApp.Model;

namespace LinqStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            Student stu1 = new Student(1, "vaibhav", 7.9, location.MUMBAI);
            Student stu2 = new Student(2, "atul", 6.9, location.NASHIK);
            Student stu3 = new Student(3, "vishal", 5.7, location.MUMBAI);
            Student stu4 = new Student(4, "sagar", 7.1, location.MUMBAI);
            Student stu5 = new Student(5, "shubhangi", 7.5, location.NASHIK);
            Student stu6 = new Student(6, "aarti", 8.1, location.MUMBAI);
            Student stu7 = new Student(7, "monu", 8.3, location.PUNE);
            Student stu8 = new Student(8, "rushabh", 8.0, location.PUNE);
            Student stu9 = new Student(9, "vijay", 7.1, location.MUMBAI);
            Student stu10 = new Student(10, "rohan", 7.6, location.PUNE);
            studentList.Add(stu1);
            studentList.Add(stu2);
            studentList.Add(stu3);
            studentList.Add(stu4);
            studentList.Add(stu5);
            studentList.Add(stu6);
            studentList.Add(stu7);
            studentList.Add(stu8);
            studentList.Add(stu9);
            studentList.Add(stu10);

            var Top5HighestCgpa = studentList.OrderByDescending(s => s.Cgpa)
                                             .Take(5);
            Console.WriteLine("--------Top 5 students with highest cgpa--------");
            PrintStudentDetails(Top5HighestCgpa);
            var StudentsLocationMumbai = studentList.Where(s => s.Location == location.MUMBAI);
            Console.WriteLine("--------Students with location Mumbai--------");
            PrintStudentDetails(StudentsLocationMumbai);
            var StudLocMum_NameAssending = studentList.Where(s => s.Location == location.MUMBAI)
                                                        .OrderBy(s => s.StudentName);
            Console.WriteLine("--------Students with location Mumbai and order by assending order by name--------");
            PrintStudentDetails(StudLocMum_NameAssending);
            
            
            var SelectClause = studentList.Select(s => new { s.StudentName,s.Cgpa});
            Console.WriteLine("--------Select student name and cgpa--------");                               
            foreach (var name in SelectClause)
            {
                Console.WriteLine(name);
            }
            
        }

        private static void PrintStudentDetails(IEnumerable<Student> top5HighestCgpa)
        {
            foreach (var student in top5HighestCgpa)
            {
                Console.WriteLine(student);
            }
        }
    }
}
