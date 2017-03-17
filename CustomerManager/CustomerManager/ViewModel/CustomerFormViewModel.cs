using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerManager.Models;

namespace CustomerManager.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public Customer Customer { get; set; }
    }
}