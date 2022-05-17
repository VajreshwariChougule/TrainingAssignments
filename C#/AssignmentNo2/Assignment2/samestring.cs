using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class samestring
    {
        public void stringsameOrNot()
        {
            Console.WriteLine("Enter String1");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter String2");
            string str2 = Console.ReadLine();

            if (str1 == str2)
            {
                Console.WriteLine("Same");
            }
            else
                Console.WriteLine("No");
        }
    }
}
