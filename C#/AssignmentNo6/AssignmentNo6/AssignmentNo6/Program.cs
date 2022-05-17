using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    interface IStudent
    {
        void ShowDetails(int id, string name);
    }
    class DaySholar : IStudent
    {
        public void ShowDetails(int id, string name)
        {
            Console.WriteLine("Student Id is:{0}\nName of the student is:{1}", id, name);
        }
    }
    class Resident : IStudent
    {
        public void ShowDetails(int id, string name)
        {
            Console.WriteLine("Student id is:{0}\n Name of the Student is{1}", id, name);
        }
    }
    class InterfaeEg
    {
        static void Main()
        {
            Console.WriteLine("Dayscholar Details");
            IStudent d = new DaySholar();
            d.ShowDetails(1, "Anaya");

            Console.WriteLine("Resident Scholar Details");
            IStudent r = new Resident();
            r.ShowDetails(2, "Anay");
            Console.ReadLine();
        }
    }
}