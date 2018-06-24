using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using OnlineShopPhono.ViewModel;
using OnlineShopPhono.Models;

namespace OnlineShopPhono.Controllers
{
    public class PhoneController : Controller
    {
        private ApplicationDbContext _context;

        public PhoneController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Phone
        public ActionResult Index(String SearchString, String sort)
        {
            // Check for user
            string view = "ReadOnlyList";
            if (User.Identity.IsAuthenticated)
                view = "List";

            ViewBag.SortByPhoneName = String.IsNullOrEmpty(sort) ? "name_desc" : "";
            ViewBag.SortByDateReleased = (sort == "date") ? "date_desc" : "date";

            var phones = _context.Phones.AsQueryable();

            if (!String.IsNullOrWhiteSpace(SearchString))
            {
                phones = phones.Where(p => p.PhoneName.Contains(SearchString));
                ViewBag.SearchPhone = SearchString;
            }

            switch (sort)
            {
                case "name_desc":
                    phones = phones.OrderByDescending(p => p.PhoneName);
                    break;
                case "date":
                    phones = phones.OrderBy(p => p.DateRelease);
                    break;
                case "date_desc":
                    phones = phones.OrderByDescending(p => p.DateRelease);
                    break;
                default:
                    phones = phones.OrderBy(p => p.PhoneName);
                    break;
            }
            return View(view, phones.ToList());
        }

        public ActionResult Details(int id)
        {
            var phone = _context.Phones
                .Include(c => c.Brand)
                .Include(c => c.PhoneType)
                .SingleOrDefault(c => c.ID == id);

            if (phone == null)
                return HttpNotFound();

            return View(phone);
        }

        [Authorize]
        public ActionResult New()
        {
            var viewModel = new PhoneFormViewModel()
            {
                Phone = new Phone(),
                Brands = _context.Brands.ToList(),
                PhoneTypes = _context.PhoneTypes.ToList()
            };

            // give a default value with current date
            viewModel.Phone.DateRelease = DateTime.Now;

            return View("PhoneForm", viewModel);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var phoneInDB = _context.Phones.Single(m => m.ID == id);

            if (phoneInDB == null)
                return HttpNotFound();

            var viewModel = new PhoneFormViewModel()
            {
                Phone = phoneInDB,
                Brands = _context.Brands.ToList(),
                PhoneTypes = _context.PhoneTypes.ToList()
            };

            return View("PhoneForm", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Phone phone)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PhoneFormViewModel()
                {
                    Phone = phone,
                    Brands = _context.Brands.ToList(),
                    PhoneTypes = _context.PhoneTypes.ToList()
                };

                return View("PhoneForm", viewModel);
            }

            if (phone.ID == 0)
            {
                _context.Phones.Add(phone);
            }
            else
            {
                var phoneInDB = _context.Phones.Single(m => m.ID == phone.ID);

                // Manually update the fields I want.
                phoneInDB.PhoneName = phone.PhoneName;
                phoneInDB.BrandId = phone.BrandId;
                phoneInDB.DateRelease = phone.DateRelease;
                phoneInDB.ScreenSize = phone.ScreenSize;
                phoneInDB.PhoneTypeId = phone.PhoneTypeId;
            }


            _context.SaveChanges();

            return RedirectToAction("Index", "Phone");
        }

        [Authorize]
        public ActionResult Delete(int? id)
        {
            var phone = _context.Phones
                .Include(m => m.Brand)
                .Include(m => m.PhoneType)
                .SingleOrDefault(c => c.ID == id);

            if (phone == null)
                return HttpNotFound();

            return View(phone);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var phoneInDB = _context.Phones.Find(id);

            _context.Phones.Remove(phoneInDB);
            _context.SaveChanges();

            return RedirectToAction("Index", "Phone");
        }


    }

}