using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerManager.Models;

namespace CustomerManager.ViewModel
{
    public class CustomerDeleteModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public Customer Customer { get; set; }
    }
}