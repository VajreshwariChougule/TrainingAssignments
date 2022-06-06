using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CaseStudy
{
    public class Info
    {
        public static void display(Student student)
        {
            Console.WriteLine("Student id is " + student.StudentId + " and student name is " + student.StudentName + " and date of birth is " + student.DateOfBirth);
        }
        public static void display(Course course)
        {
            Console.WriteLine("Course id is " + course.Id + " Course name is " + course.Name + " couse duration is " + course.duration + " course fee is " + course.fees);
        }
        public static void display(Enroll enroll)
        {
            Console.WriteLine("Enrollment Details");
            display(enroll.students);
            display(enroll.courses);
            Console.WriteLine("Date of Enrollment is " + enroll.datetime);
        }
    }
}