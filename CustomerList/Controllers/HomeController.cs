using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerList.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerList.Controllers
{
    public class HomeController : Controller
    {
        private CustomerContext context { get; set; }

        public HomeController(CustomerContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            List<Customer> customers = context.Customers.Include(c => c.Gender).OrderBy(c => c.LastName).ToList();
            return View(customers);
        }
    }
}
