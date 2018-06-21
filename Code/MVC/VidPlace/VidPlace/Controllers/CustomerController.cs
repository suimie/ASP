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
                Customer = new Customer(),
                Memberships = _context.Memberships.ToList()
            };
            return View("CustomerForm", viewModel);  // CustomerForm is the file name in View folder
        }

        //public ActionResult Save(CustomerFormViewModel viewMode)
        // Saveing action into DB
        // Post action
        [HttpPost]      // to make access from the from not typing url
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)   // It takes just customer class from the form
        {
            // Server side validation
            if (!ModelState.IsValid)
            {
                // The form is not valid --> return same form to the user

                var viewModel = new CustomerFormViewModel()
                {
                    Customer = customer,
                    Memberships = _context.Memberships.ToList()
                };

                return View("CustomerForm", viewModel);
            }

            // *********** Come here if form is valid
            if (customer.ID == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDB = _context.Customers.Single(c => c.ID == customer.ID);

                /*
                 * This method has a security flow.
                TryUpdateModel(customerInDB);
                */

                // Manually update the fields I want.
                customerInDB.Name = customer.Name;
                customerInDB.Address = customer.Address;
                customerInDB.Birthday = customer.Birthday;
                customerInDB.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                customerInDB.MembershipId = customer.MembershipId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
            var customerInDB = _context.Customers.SingleOrDefault(c => c.ID == id);

            if (customerInDB == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customerInDB,
                Memberships = _context.Memberships.ToList()
            };

            return View("CustomerForm", viewModel);  
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