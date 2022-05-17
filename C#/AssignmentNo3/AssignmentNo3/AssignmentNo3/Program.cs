using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // student marks program
            Student_Info student = new Student_Info(0046, "vajreshwari", "BE", "1stsem", "mech");
            student.displaydata();
            student.displayresult();

            // car program

            Car_Info car = new Car_Info(4693, "RangeRover", "Sport");
            car.displaycardetails();
            Car_Info car2 = new Car_Info(500000);

            // Loan amount calculator

            Interest_Amt ia = new Interest_Amt();
            ia.loanCalculator(200000);
            Console.ReadLine();
        }
    }
}
