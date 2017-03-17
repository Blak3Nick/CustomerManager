using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerManager.Models;
using CustomerManager.ViewModel;
using Microsoft.Ajax.Utilities;

namespace CustomerManager.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            var customers = new List<Customer>
            {
                new Customer {Name = "Cust1"},
                new Customer {Name = "Cust2"}
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);

        }
        [Route("customers/name/name")]
        public ActionResult ByName(string name)
        {

            return View();
        }
    }
}