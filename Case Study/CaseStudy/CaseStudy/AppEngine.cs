using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CaseStudy
{
    class AppEngine
    {
        //Student[] students;
        //Course[] courses;
        //Enroll[] enrolls;
        //public int studentlistsize;
        //public int courselistsize;
        //public int enrolllistsize;
        //public AppEngine()
        //{
        // this.students = new Student[3];
        // this.courses = new Course[3];
        // this.enrolls = new Enroll[3];
        // this.studentlistsize = 0;
        // this.courselistsize = 0;
        // this.enrolllistsize = 0;
        //}
        //public void introduce(Course course)
        //{
        // courses[this.courselistsize] = course;
        // courselistsize += 1;
        //}
        //public void register(Student student)
        //{
        // students[this.studentlistsize] = student;
        // studentlistsize += 1;
        //}
        //public Student[] listOfStudents()
        //{
        // return students;
        //}
        //public Course[] listOfCourses()
        //{
        // return courses;
        //}
        //public void enroll(Student student, Course course)
        //{
        // Enroll enroll = new Enroll(student, course, new DateTime());
        // enrolls[this.enrolllistsize] = enroll;
        // this.enrolllistsize += 1;
        //}
        //public Enroll[] listOfEnrollments()
        //{
        // return this.enrolls;
        //}


        ///* Case Study-3 */


        //List<Student> students;
        //List<Course> courses;
        //List<Enroll> enrolls;
        //public AppEngine()
        //{
        // this.students = new List<Student>();
        // this.courses = new List<Course>();
        // this.enrolls = new List<Enroll>();
        //}
        //public void introduce(Course course)
        //{
        // courses.Add(course);
        //}
        //public void register(Student student)
        //{
        // students.Add(student);
        //}
        //public List<Student> listOfStudents()
        //{
        // // return students;
        //
        //}
        //public List<Course> listOfCourses()
        //{
        // // return courses;
        //
        //}
        //public void enroll(Student student, Course course)
        //{
        // Enroll e = new Enroll(student, course, new DateTime());
        // this.enrolls.Add(e);
        //}
        // public List<Enroll> listOfEnrollments()
        // {
        // // return enrolls;
        //
        // }
        public void introduce(Course course)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("insert into Course values(@cid,@cname,@cdur,@fee)", con);
                cmd.Parameters.AddWithValue("@cid", course.Id);
                cmd.Parameters.AddWithValue("@cname", course.Name);
                cmd.Parameters.AddWithValue("@cdur", course.duration);
                cmd.Parameters.AddWithValue("@fee", course.fees);
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Value Updated");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                con.Close();
            }
        }
        public void register(Student student)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("insert into Student values(@sid,@sname,@dob)", con);
                cmd.Parameters.AddWithValue("@sid", student.StudentId);
                cmd.Parameters.AddWithValue("@sname", student.StudentName);
                cmd.Parameters.AddWithValue("@dob", student.DateOfBirth);
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Value Updated");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                con.Close();
            }
        }
        public void enroll(Student student, Course course)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                string dt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                con = SQLConnection.getcon();


                cmd = new SqlCommand("insert into Enroll values(@sid,@cid,@doe)", con);
                cmd.Parameters.AddWithValue("@sid", student.StudentId);
                cmd.Parameters.AddWithValue("@cid", course.Id);
                cmd.Parameters.AddWithValue("@doe", dt);
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Value Updated");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                con.Close();
            }
        }
        public Student GetStudentById(int sid)
        {
            Student student = null;
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            con = SQLConnection.getcon();
            cmd = new SqlCommand("select * from Student where studentId=@sid", con);
            cmd.Parameters.AddWithValue("@sid", sid);
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    student = new Student((int)dr["studentId"], (string)dr["studentName"], (string)dr["dateOfBirth"]);
                }
            }
            con.Close();
            return student;
        }
        public Course GetCourseById(int cid)
        {
            Course course = null;
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            con = SQLConnection.getcon();
            cmd = new SqlCommand("select * from Course where CourseId=@cid", con);
            cmd.Parameters.AddWithValue("@cid", cid);
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    course = new Course((int)dr["CourseId"], (string)dr["CourseName"], (int)dr["duration"], Convert.ToDouble(dr["CourseFees"]));
                }
            }
            con.Close();
            return course;
        }

    }
}