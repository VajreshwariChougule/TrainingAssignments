using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Customers.Models;

namespace MVC_Customers.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cust_in_Germany()
        {
            List<Customer> customers = (from cust in db.Customers
                                        where cust.Country == "Germany"
                                        select cust).ToList();
            return View(customers);
        }
        public ActionResult GetCustomers_ById()
        {
            List<Customer> customers = (from cust in db.Customers
                                        join orders in db.Orders on cust.CustomerID equals orders.CustomerID
                                        where orders.OrderID == 10248
                                        select cust).ToList();
            return View(customers);
        }
    }
}