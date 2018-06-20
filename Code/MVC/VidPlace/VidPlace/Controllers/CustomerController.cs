using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using VidPlace.Models;
using VidPlace.ViewModels;
using System.Data.Entity;

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

            var customers = _context.Customers.Include(c =>c.Membership).ToList();

            return View(customers);
        }

        // GET: Customer/Details
        public ActionResult Details(int id)
        {
            //var customer = getCustomers().SingleOrDefault(c => c.ID == id);
            var customer = _context.Customers.Include(c => c.Membership).SingleOrDefault(c => c.ID == id);
            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

        public ActionResult New()
        {
            //var customer = new Customer();

            var viewModel = new CustomerFormViewModel()
            {
                Memberships = _context.Memberships.ToList(),
            };
            return View("CustomerForm", viewModel);  // CustomerForm is the file name in View folder
        }

        /*
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
        */
    }
}