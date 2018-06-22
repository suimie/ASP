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
        public ActionResult Index()
        {
            var phones = _context.Phones.ToList();

            return View(phones);
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
        public ActionResult Delete(int id)
        {
            var phoneInDB = _context.Phones.Single(m => m.ID == id);

            _context.Phones.Remove(phoneInDB);
            _context.SaveChanges();

            return RedirectToAction("Index", "Phone");
        }
    }

}