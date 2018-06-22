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
        public ActionResult Index(string SearchString, string sort)
        {
            // Check for user
            string view = "ReadonlyList";
            if (User.IsInRole(RoleNames.CanManageMedia))
                view = "List";

            //var customers = getCustomers();

            var customers = _context.Customers.Include(c =>c.Membership);

            ViewBag.SortByName = string.IsNullOrEmpty(sort) ? "name_desc" : "";
            ViewBag.SortByMembership = (sort == "membership") ? "membership_desc" : "membership";

            if (!string.IsNullOrWhiteSpace(SearchString))
            {
                // in LINQ
                //customers = (from c in customers where c.Name.Contains(SearchString) select c);
                customers = customers.Where(c => c.Name.Contains(SearchString));

                ViewBag.search = SearchString;
            }

            switch (sort)
            {
                case "name_desc":
                    customers = customers.OrderByDescending(c => c.Name);
                    break;
                case "membership_desc":
                    customers = customers.OrderByDescending(c => c.MembershipId);
                    break;
                case "membership":
                    customers = customers.OrderBy(c => c.MembershipId);
                    break;
                default:
                    customers = customers.OrderBy(c => c.Name);
                    break;
            }

            return View(view, customers.ToList());
        }

        // GET: Customer/Details
        [Authorize]
        public ActionResult Details(int id)
        {
            //var customer = getCustomers().SingleOrDefault(c => c.ID == id);
            var customer = _context.Customers.Include(c => c.Membership).SingleOrDefault(c => c.ID == id);
            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

        [Authorize(Roles = RoleNames.CanManageMedia)]
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

        [Authorize(Roles = RoleNames.CanManageMedia)]
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

        [Authorize(Roles = RoleNames.CanManageMedia)]
        public ActionResult Delete(int? id)
        {
            var customer = _context.Customers
                .Include(m => m.Membership)
                .SingleOrDefault(c => c.ID == id); 

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var customerInDB = _context.Customers.Find(id); // search with primary key

            _context.Customers.Remove(customerInDB);
            _context.SaveChanges();

            return RedirectToAction("Index");
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