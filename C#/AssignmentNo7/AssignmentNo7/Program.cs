using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo7
{
    class Employee
    {  
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime DOB { get; set; }
            public DateTime DOJ { get; set; }
            public string City { get; set; }

            public List<Employee> employees()
            {
                List<Employee> empList = new List<Employee>();

                Employee e1 = new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 06, 08), City = "Mumbai" };
                Employee e2 = new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 08, 20), DOJ = new DateTime(2012, 07, 07), City = "Mumbai" };
                Employee e3 = new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 04, 12), City = "Pune" };
                Employee e4 = new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 06, 03), DOJ = new DateTime(2016, 02, 02), City = "Pune" };
                Employee e5 = new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 03, 08), DOJ = new DateTime(2016, 02, 02), City = "Mumbai" };
                Employee e6 = new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Cosultant", DOB = new DateTime(1989, 11, 07), DOJ = new DateTime(2014, 08, 08), City = "Chennai" };
                Employee e7 = new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 02), DOJ = new DateTime(2015, 06, 01), City = "Mumbai" };
                Employee e8 = new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 06), City = "Chennai" };
                Employee e9 = new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 08, 12), DOJ = new DateTime(2014, 12, 03), City = "Chennai" };
                Employee e10 = new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1981, 04, 12), DOJ = new DateTime(2016, 01, 02), City = "Pune" };
                empList.Add(e1);
                empList.Add(e2);
                empList.Add(e3);
                empList.Add(e4);
                empList.Add(e5);
                empList.Add(e6);
                empList.Add(e7);
                empList.Add(e8);
                empList.Add(e9);
                empList.Add(e10);
                return empList;
            }      
    }
    class Program
    {
        static void Main(string[] args)
        {
            //To display list of all the employee whose date of birth is after 1/1/1990
            Employee e = new Employee();
            Console.WriteLine("list of all the employee whose date of birth is after 1/1/1990");
            var dob = from d in e.employees()
                      where d.DOB > DateTime.Parse("1/1/1990")
                      select d;

            foreach (var v in dob)
            {

                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            
            //To display list of all the employee whose designation is Consultant and Associate
            Console.WriteLine("list of all the employee whose designation is Consultant and Associate");
            var title = from t in e.employees()
                        where t.Title == "Consultant" || t.Title == "Associate"
                        select t;
            foreach (var v in title)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            
            //To display total number of employees
            Console.WriteLine("total number of employees");
            var total = from t in e.employees()
                        select t;
            foreach (var v in total)
            {
                Console.WriteLine($"Employye Name = {v.FirstName}{v.LastName}");
            }
            
            //To display total number of employees belonging to “Chennai”
            Console.WriteLine("total number of employees belonging to “Chennai”");
            IEnumerable<Employee> location = from l in e.employees()
                                             where l.City == "Chennai"
                                             select l;
            foreach (var v in location)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            
            //To display highest employee id from the list
            Console.WriteLine("highest employee id from the list");
            var high = (from h in e.employees()
                        select h.EmployeeID).Max();
            Console.WriteLine(high);
            
            //To display total number of employee who have joined after 1/1/2015
            Console.WriteLine("total number of employee who have joined after 1/1/2015");
            var date = from d in e.employees()
                       where d.DOJ > DateTime.Parse("1/1/2015")
                       select d;

            foreach (var v in date)
            {

                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            
            //To display total number of employee whose designation is not “Associate”
            Console.WriteLine("total number of employee whose designation is not “Associate”");
            IEnumerable<Employee> titl = from t in e.employees()
                                         where t.Title != "Associate"
                                         select t;
            foreach (var v in titl)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            
            //To display total number of employee based on City
            Console.WriteLine("total number of employee based on City");
            var sort = from v in e.employees()
                       orderby v.City
                       select v;
            foreach (var v in sort)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            
            //To display total number of employee based on city and title
            Console.WriteLine("total number of employee based on city and title");
            var sorted = from v in e.employees()
                         orderby v.City
                         orderby v.FirstName
                         select v;
            foreach (var v in sorted)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            
            //To display total number of employee who is youngest in the list
            Console.WriteLine("total number of employee who is youngest in the list");
            var res = e.employees().OrderByDescending(a => a.DOB).Take(1);
            foreach (var v in res)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            Console.ReadLine();
        }
     }
}

