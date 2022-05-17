using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public DateTime DOJ { get; set; }
        public string DOB { get; set; }
        string City { get; set; }

        public override string ToString()
        {
            return EmployeeID + " " + FirstName + " " + LastName + " " + Title + " " + DOJ + " " + DOB + " " + City;
        }
        static void Main(string[] args)
        {
            List<Employee> Emp1 = new List<Employee>()
            {



new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB =" 16/11/1984",
    DOJ =DateTime.Parse("8/6/2011"), City = "Mumbai" },
new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = "20/08/1984",
    DOJ =DateTime.Parse("7/7/2012"), City = "Mumbai" },
new Employee { EmployeeID = 1003, FirstName = " Madhavi", LastName = " Oza", Title = " Consultant ", DOB = " 14 / 11 / 1987",
    DOJ = DateTime.Parse("12/4 / 2015"), City = "Pune" },
new Employee { EmployeeID = 1004, FirstName = "Saba ", LastName = "Shaikh", Title = "SE", DOB = "3 / 6 / 1990",
    DOJ = DateTime.Parse("2 / 2 / 2016"), City = " Pune" },
new Employee { EmployeeID = 1005, FirstName = "  Nazia", LastName = "Shaikh", Title = "SE", DOB = "8 / 3 / 1991",
    DOJ = DateTime.Parse(" 2 / 2 / 2016"), City = "Mumbai" },
new Employee { EmployeeID = 1006, FirstName = " Amit", LastName = "Pathak", Title = "Consultant ", DOB = "7 / 11 / 1989",
    DOJ =DateTime.Parse( " 8 / 8 / 2014"), City = " Chennai" },
new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan ", Title = "Consultant", DOB = " 2 / 12 / 1989",
    DOJ =DateTime.Parse( "1 / 6 / 2015"), City = "Mumbai" },
new Employee { EmployeeID = 1008, FirstName = "  Rahul", LastName = " Dubey", Title = " Associate  ", DOB = "11 / 11 / 1993",
    DOJ = DateTime.Parse("6 / 11 / 2014"), City = "Chennai" },
new Employee { EmployeeID = 1009, FirstName = " Suresh", LastName = "Mistry ", Title = " Associate", DOB = "12 / 8 / 1992",
    DOJ = DateTime.Parse("3 / 12 / 2014"), City = "Chennai" },
new Employee { EmployeeID = 1010, FirstName = "  Sumit", LastName = " Shah", Title = "Manager", DOB = "12 / 4 / 1991",
    DOJ = DateTime.Parse(" 2 / 1 / 2016"), City = " Pune" },

        };

            //Details of all the employee
            IEnumerable<Employee> Query1 = from Employee in Emp1
                                           select Employee;
            Console.WriteLine("All the Employee Details");

            foreach (Employee e in Query1)
            {
                Console.WriteLine(e.ToString());

            }

            //Details of all the employee whose location is not Mumbai
            IEnumerable<Employee> Query2 = from Employee in Emp1
                                           where Employee.City != "Mumbai"
                                           select Employee;
            Console.WriteLine("Whos location  is not mumbai");

            foreach (Employee e in Query2)
            {

                Console.WriteLine(e.ToString());
            }

            //Details of all the employee whose title is AsstManager
            IEnumerable<Employee> Query = from Employee in Emp1
                                          where Employee.Title == "AsstManager"
                                          select Employee;
            Console.WriteLine("Who is working in  AsstManager");
            foreach (Employee e in Query)
            {

                Console.WriteLine(e.ToString());
            }

            //Details of all the employee whose Last Name start with S
            IEnumerable<Employee> Query3 = from Employee in Emp1
                                           where Employee.LastName.StartsWith("S")
                                           select Employee;
            Console.WriteLine("Whos Name Start With S ");

            foreach (Employee e in Query3)
            {

                Console.WriteLine(e.ToString());
            }

            //A list of all the employee who have joined before 1/1/2015
            IEnumerable<Employee> Query4 = from Employee in Emp1
                                           where Employee.DOJ <= DateTime.Parse("01/01/2015")
                                           select Employee;


            Console.WriteLine("Who is Joined Before 2015 ");

            foreach (Employee e in Query4)
            {

                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();

        }
    }
}