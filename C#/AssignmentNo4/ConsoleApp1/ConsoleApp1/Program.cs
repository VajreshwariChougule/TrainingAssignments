using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RunClass
    {
        static void Main(string[] args)
        {
            student s = new student();
            //Console.WriteLine($"Total Fees{total}");
            Console.WriteLine("Enter your choice:/n  1: Transport 2: hostel");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    s.DisplayDetails();
                    Console.WriteLine("Transport Student");
                    DayScholar ds = new DayScholar();
                    break;
                case 2:
                    //student s= new student();
                    s.DisplayDetails();
                    Console.WriteLine("Hostel Student");
                    Hosteller hs = new Hosteller();
                    break;
            }
            //hs.payFee();
            Console.ReadLine();
        }
    }
}
