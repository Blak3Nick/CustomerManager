using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerManager.Models;

namespace CustomerManager.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = new Customer() {Name = "Caleb Thompson"};
            return View(customer);
        }
    }
}