using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Pallindrome
    {

        public void strPallindrome()
        {
            Console.WriteLine("Enter String");
            string name = Console.ReadLine();
            string st1 = "";
            int n = name.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                char ch = name[i];
                st1 = st1 + ch;

            }
            if (name.Equals(st1))
                Console.WriteLine("Given name is Pallindrome : " + name);
            else
                Console.WriteLine("Given name is not Pallindrome : " + name);
        }
    }
}
