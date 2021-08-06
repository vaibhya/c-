using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStudentApp.Model
{
    class Student
    {
        private int _studentId;
        private String _studentName;
        private double _cgpa;
        private location _stuLocation;
        public Student(int studentId,String studentName,double cgpa,location stuLocation)
        {
            _studentId = studentId;
            _studentName = studentName;
            _cgpa = cgpa;
            _stuLocation = stuLocation;
        }
        public int StudentId
        {
            get { return _studentId; }
        }
        public String StudentName
        {
            get { return _studentName; }
        }
        public double Cgpa
        {
            get { return _cgpa; }
        }
        public location Location
        {
            get { return _stuLocation; }
        }
        public override string ToString()
        {
            return "Student Name: "+_studentName+" Id: "+_studentId+" Cgpa: "+_cgpa+" Location: "+_stuLocation;
        }
    }
}
