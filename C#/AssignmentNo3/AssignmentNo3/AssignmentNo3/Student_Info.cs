using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo3
{
    internal class Student_Info
    {
        int rollno;
        string name;
        string stclass;
        string semister;
        string branch;

        public void displayresult()
        {
            int[] marks = new int[5];
            marks[0] = 30;
            marks[1] = 50;
            marks[2] = 40;
            marks[3] = 44;
            marks[4] = 70;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

            double average = marks.Average();
            Console.WriteLine("The total subject of average : " + average);

            for (int i = 0; i < marks.Length; i++)
            {

                if (marks[i] < 35)
                {
                    Console.WriteLine(marks[i] + " subject is failed");
                }
                else if (marks[i] > 35 && average < 50)
                {
                    Console.WriteLine("student is failed");
                }
                else if (average > 50)
                {
                    Console.WriteLine("student is passed ");
                }
                else
                {
                    Console.WriteLine("enter valid details");
                }
            }

        }

        public Student_Info(int rollno, String name, string stclass, string semister, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.stclass = stclass;
            this.semister = semister;
            this.branch = branch;
            Console.WriteLine($"rollno is:{rollno}, name is{name},student class is{stclass},semister is{semister},branch is :{branch}");

        }
        public void displaydata()
        {
            Console.WriteLine("the result is");

        }
    }
}
