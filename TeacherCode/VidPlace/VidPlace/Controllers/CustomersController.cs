using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using System.Data.Entity;
using VidPlace.ViewModels;

namespace VidPlace.Controllers
{
    public class CustomersController : Controller
    {
        //DBContext Object
        private ApplicationDbContext _context;

        //class constructor - (shotcut for constructor=ctor)
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customers/Index
        public ActionResult Index()
        {
            //var customers = GetCustomers();
            //var emptyList = new List<Customer>();
            var customers = _context.Customers.Include(c => c.Membership).ToList();
            return View(customers);
        }

        // GET: Customers/Details
        public ActionResult Details(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.ID == id);
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
            return View("CustomerForm", viewModel);
        }

        //Saving action into DB
        //Post action
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            //Server side validation
            if(!ModelState.IsValid)
            {
                //The form is not valid --> return same form to the user
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    Memberships = _context.Memberships.ToList()
                };

                return View("CustomerForm", viewModel);
            }
            //******** Come here if form is valid
            if (customer.ID == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDB = _context.Customers.Single(c => c.ID == customer.ID);

                /*
                TryUpdateModel(customerInDB);

                This method has a security flow.
                */

                //Manually update the fields I want.
                customerInDB.Name = customer.Name;
                customerInDB.address = customer.address;
                customerInDB.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                customerInDB.MembershipId = customer.MembershipId;
                customerInDB.Birthdate = customer.Birthdate;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int Id)
        {
            var customerInDB = _context.Customers.SingleOrDefault(c => c.ID == Id);

            if (customerInDB == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customerInDB,
                Memberships = _context.Memberships.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        /*
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){ID = 1, Name = "Jonh Smith"},
                new Customer(){ID = 2, Name = "Sally Ben"}
            };
        }*/
    }
}