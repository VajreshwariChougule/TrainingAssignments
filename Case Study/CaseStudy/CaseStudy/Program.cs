using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CaseStudy
{
    public class Student
    {
        private int studentId;
        private string studentName;
        private string dateOfBirth;
        public Student(int studentId, string studentName, string dateOfBirth)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.dateOfBirth = dateOfBirth;
        }
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
    }
    public class Course
    {
        public int Id;
        public string Name;
        public int duration;
        public double fees;


        public Course(int Id, string Name, int duration, double fee)
        {
            this.Id = Id;
            this.Name = Name;
            this.duration = duration;
            this.fees = fee;
        }
    }
}