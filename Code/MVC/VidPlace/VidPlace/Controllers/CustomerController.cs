using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using VidPlace.Models;
using VidPlace.ViewModels;

namespace VidPlace.Controllers
{
    public class CustomerController : Controller
    {
        //DBContext Object
        private ApplicationDbContext _context;

        // class constructor - {shortcut for constructor : ctor <TAB><TAB>}
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customer/Index
        public ActionResult Index()
        {
            //var customers = getCustomers();

            var customers = _context.Customers.ToList();

            return View(customers);
        }

        // GET: Customer/Details
        public ActionResult Details(int id)
        {
            //var customer = getCustomers().SingleOrDefault(c => c.ID == id);
            var customer = _context.Customers.SingleOrDefault(c => c.ID == id);
            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }



        public IEnumerable<Customer> getCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer() { ID=1, Name = "Thomas Edison" },
                new Customer() { ID=2, Name = "Alex ABC" },
                new Customer() { ID=3, Name = "Sue Smith" }
            };

            return customers;
        }

    }
}