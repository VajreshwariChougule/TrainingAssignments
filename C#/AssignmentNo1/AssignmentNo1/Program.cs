using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Que.. 1 Checking for equal or not equal
            Console.WriteLine("Enter integer 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("Two intergers are equal");
            }
            else
            {
                Console.WriteLine("Two interegrs are not equal");
            }

            // Que. 2 Checking for positive or negative
            int number;
            Console.WriteLine("Enter the number to check whether it is positive or negative");
            number = int.Parse(Console.ReadLine());
            if(number > 0)
            {
                Console.WriteLine("Given number is Positive");
            }
            else
            {
                Console.WriteLine("Given number is Negative");
            }

            //Que. 3 Operator
            int number1, number2, result;
            char operation;
            Console.Write("Enter the first number :");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number :");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the operation");
            Console.WriteLine("1 addititon");
            Console.WriteLine("2 subtraction");
            Console.WriteLine("3 multiplication");
            Console.WriteLine("4 division");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    result = number1 + number2;
                    Console.WriteLine("The addition of two number is : {0}", result);
                    break;
                case '2':
                    result = number1 - number2;
                    Console.WriteLine("The subtraction of two number is : {0}", result);
                    break;
                case '3':
                    result = number1 * number2;
                    Console.WriteLine("The multiplication of two number is : {0}", result);
                    break;
                case '4':
                    result = number1 / number2;
                    Console.WriteLine("The division of two number is : {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
           
            Console.ReadLine();
        }
    }
}
