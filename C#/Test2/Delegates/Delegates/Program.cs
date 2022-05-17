using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void calculator(int a, int b);

    class Program
    {
        public static void addition(int a, int b)
        {
            int res = a + b;
            Console.WriteLine($"Addition result is {res}");
        }
        public static void substraction(int a, int b)
        {
            int res = a - b;
            Console.WriteLine($"Substraction result is {res}");
        }
        public static void multiplication(int a, int b)
        {
            int res = a * b;
            Console.WriteLine($"Multiplication result is {res}");
        }
        public static void division(int a, int b)
        {
            int res = a / b;
            Console.WriteLine($"Division result is {res}");
        }
        static void Main(string[] args)
        {
            calculator obj = new calculator(Program.addition);
            obj.Invoke(10, 10);
            obj = substraction;
            obj(10, 10);
            obj = multiplication;
            obj(10, 10);
            obj = division;
            obj(10, 10);
            Console.ReadLine();
        }
    }
}
