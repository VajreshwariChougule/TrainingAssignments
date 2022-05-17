using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class StringAssignment1
    {

        public void stringlength()
        {
            Console.WriteLine("Enter user name");
            string name = Console.ReadLine();
            Console.WriteLine("user given name is : " + name);
            Console.WriteLine("length of the String is : " + name.Length);
            int n = name.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                char ch = name[i];
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
}
