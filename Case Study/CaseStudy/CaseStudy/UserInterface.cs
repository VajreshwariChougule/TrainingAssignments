using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CaseStudy
{
    public interface UserInterface
    {
        void showFirstScreen();
        void showStudentScreen();
        void showAdminScreen();
        void showAllStudentsScreen();
        void showStudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCoursesScreen();
        void updateCourseDetails();
        void viewAllEnrollments();

    }

    public class SMS : UserInterface
    {
        AppEngine appEngine;
        //int studentidseq;
        //int courseseq;
        public SMS()
        {
            this.appEngine = new AppEngine();
            //this.studentidseq = 1;
            //this.courseseq = 10;
        }
        public void introduceNewCourseScreen()
        {
            Console.WriteLine("Enter course id");
            int courseid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course name");
            string course = Console.ReadLine();
            Console.WriteLine("Enter course duration");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course fee");
            double fee = Convert.ToInt32(Console.ReadLine());
            Course course1 = new Course(courseid, course, duration, fee);
            appEngine.introduce(course1);
            //this.courseseq++;
            Console.WriteLine("Course added succesfully");
            showAdminScreen();
        }

        public void showAdminScreen()
        {
            Console.WriteLine("Welcome to Admin Screen");
            Console.WriteLine("Enter \n1 To Introuduce new Course \n2 to Update Course Details \n3 to Student Enroll \n4 view all enrollments");
            int ip = Convert.ToInt32(Console.ReadLine());

            if (ip == 1)
            {
                introduceNewCourseScreen();
            }           
            else if(ip == 2)
            {
                updateCourseDetails();
            }           
            else if (ip == 3)
            {
                studentEnroll();
            }
            else if (ip == 4)
            {
                viewAllEnrollments();
            }
            else
            {
                Console.WriteLine("Enter valid input");
                showAdminScreen();
            }
        }

        public void showAllCoursesScreen()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("List of courses available");
            //foreach(var v in appEngine.listOfCourses())
            //{
            // Info.display(v);
            //}
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from course", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("course id :" + dr[0]);
                    Console.WriteLine("course name :" + dr[1]);
                    Console.WriteLine("course duration :" + dr[2]);
                    Console.WriteLine("course fees :" + dr[3]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            showFirstScreen();
        }

        public void showAllStudentsScreen()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("List of Students registered");
            //foreach(var v in appEngine.listOfStudents())
            //{
            // Info.display(v);
            //}
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from Student", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("student id :" + dr[0]);
                    Console.WriteLine("student name :" + dr[1]);
                    Console.WriteLine("date of birth :" + dr[2]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            showAdminScreen();
        }

        public void showFirstScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            if(op == 1)
            {
                showStudentScreen();
            }
            else if(op == 2)
            {
                showAdminScreen();
            }
            else
            {
                Console.WriteLine("Enter valid input");
                showFirstScreen();
            }
         
        }

        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("Enter student id");
            int sid= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter DOB(dd/mm/yyyy)");
            string dob = Console.ReadLine();
            Student student = new Student(sid, sname, dob);
            appEngine.register(student);
            //this.studentidseq++;
            Console.WriteLine("Student registered succesfully");
            showStudentScreen();
        }

        public void showStudentScreen()
        {
            Console.WriteLine("Welcome to Student Screen");
            Console.WriteLine("Enter \n1 to Registration \n2 to Show all Courses \n3 to Show Students");
            int ip = Convert.ToInt32(Console.ReadLine());
            
            if (ip == 1)
            {
                showStudentRegistrationScreen();
            }
            else if(ip == 2)
            {
                showAllCoursesScreen();
            }
            else if (ip == 3)
            {
                showAllStudentsScreen();
            }
            else
            {
                Console.WriteLine("Enter valid input");
                showStudentScreen();
            }
        }
        public void studentEnroll()
        {
            Console.WriteLine("Enter sid");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course id");
            int cid = Convert.ToInt32(Console.ReadLine());
            Student student = appEngine.GetStudentById(sid);
            Course course = appEngine.GetCourseById(cid);
            if (student == null)
            {
                Console.WriteLine("No student available with id");
            }
            else
            {
                if (course == null)
                {
                    Console.WriteLine("No course available with id");
                }
                else
                {
                    appEngine.enroll(student, course);
                }
            }
        }
        public void viewAllEnrollments()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("All Enrollment Details");
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from Enroll", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("student id :" + dr[0]);
                    Console.WriteLine("course id :" + dr[1]);
                    Console.WriteLine("date of enrollment :" + dr[2]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void updateCourseDetails()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;



            Console.WriteLine("Updating course details");
            try
            {
                con = SQLConnection.getcon();
                Console.WriteLine("Enter course id to update course");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter course name:");
                string cname = Console.ReadLine();
                Console.WriteLine("Enter duration");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter fees");
                double fees = Convert.ToDouble(Console.ReadLine());
                cmd = new SqlCommand("update Course set CourseName =@name where CourseId=@sid", con);
                cmd.Parameters.AddWithValue("@name", cname);
                cmd.Parameters.AddWithValue("@dur", dur);
                cmd.Parameters.AddWithValue("@fee", fees);
                cmd.Parameters.AddWithValue("@sid", sid);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Record updated");
                }
                else Console.WriteLine("Not updated");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}