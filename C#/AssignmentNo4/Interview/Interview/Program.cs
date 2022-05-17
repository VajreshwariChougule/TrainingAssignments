using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter id:");
            //int id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter salary");
            //int salary = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter wages");
            //int wages = int.Parse(Console.ReadLine());
            Employee e = new PartTimeEmployee(4, "Ram", 5000);
            e.Details();
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int Id;
        public string EmpName;
        public int Salary;
        public Employee(int id, string Name, int salary)
        {
            Id = id;
            EmpName = Name;
            Salary = salary;
        }
        public virtual void Details()
        {
            Console.WriteLine($"{Id} {EmpName}");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public int wages = 50000;
        int total;
        public PartTimeEmployee(int id, string Name, int salary) : base(id, Name, salary)
        {

        }
        public override void Details()
        {
            Console.WriteLine($"ID:{Id} Name:{EmpName} Total:{wages + Salary}");
        }
    }
}
