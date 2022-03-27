using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerList.Models;

namespace CustomerList.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerContext context { get; set; }

        public CustomerController(CustomerContext ctx)
        {
            context = ctx;
        }
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Genders = context.Genders.OrderBy(g => g.Name).ToList();
            return View("Edit", new Customer());
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Genders = context.Genders.OrderBy(g => g.Name).ToList();
            var customer = context.Customers.Find(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerId == 0)
                    context.Customers.Add(customer);
                else
                    context.Customers.Update(customer);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else            
            {
                ViewBag.Action = (customer.CustomerId == 0) ? "Add" : "Edit";
                ViewBag.Genders = context.Genders.OrderBy(g => g.Name).ToList();
                return View(customer);
            }
        }
        public IActionResult Delete(int id)
        {
            var customer = context.Customers.Find(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


    }
}
