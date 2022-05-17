using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public abstract class Student
    {
        public int studentID;
        public string name;
        public int grade;

        public abstract Boolean Ispassed(int grade);
    }
    public class Graduate : Student
    {
        public override bool Ispassed(int grade)
        {
            if (grade > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class UnderGraduate : Student
    {
        public override bool Ispassed(int grade)
        {
            if (grade > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
