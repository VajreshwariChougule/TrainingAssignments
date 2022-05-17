using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class student
    {
        public double total = 25000;
        public int studid;
        public string studname;
        public double examfees = 5000;
        public void DisplayDetails()
        {
            Console.WriteLine("Enter Student id:");
            studid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            studname = Console.ReadLine();
            //onsole.WriteLine("Enter exam fees paid:");
            //examfees = int.Parse(Console.ReadLine());
        }
        public double totaltransportFees;
        public double totalhostelFees;
        public double totalExamFees;
        public double payFee()
        {
            double fees = 0;
            return fees;
        }
    }
    public class DayScholar : student
    {
        double transportFees;
        public DayScholar()
        {
            Console.WriteLine("Enter paid Transport fees");
            transportFees = double.Parse(Console.ReadLine());
            double paidfee = (transportFees + examfees);
            Console.WriteLine($"paid Fee : {paidfee}");
            Console.WriteLine($"Remaining fees :{total - paidfee}");
        }
    }
    public class Hosteller : student
    {
        double hostelFees;
        public Hosteller()
        {
            Console.WriteLine("Enter paid Transport fees:");
            hostelFees = double.Parse(Console.ReadLine());
            double paidfee = (hostelFees + examfees);
            Console.WriteLine($"paid Fee: {paidfee}");
            Console.WriteLine($"Reaming fees: {total - paidfee}");
        }
    }
}
