using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isContinue = null;
            Graduate g = new Graduate();
            UnderGraduate ug = new UnderGraduate();
            do
            {
                Console.WriteLine("Please enter StudentID");
                int studentID = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter name");
                string name = Console.ReadLine().ToString();

                Console.WriteLine("Please enter grade");
                int grade = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your choice /n 1:Graduate 2:Under Graduate");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        bool b2 = ug.Ispassed(grade);
                        Console.WriteLine($"Is student Passed: {b2}");
                        break;
                    default:
                        Console.WriteLine("You entered wrong choice");
                        break;
                }
                Console.WriteLine("Do you want to continue..");
                isContinue = Console.ReadLine().ToUpper();
            } while (isContinue == "Y" || isContinue == "YES");
            Console.ReadLine();
        }
    }
}
