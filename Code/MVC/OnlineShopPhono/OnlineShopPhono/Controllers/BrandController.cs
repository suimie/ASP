using OnlineShopPhono.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OnlineShopPhono.ViewModel;
using System.Data.Entity;

namespace OnlineShopPhono.Controllers
{
    public class BrandController : Controller
    {
        private ApplicationDbContext _context;

        public BrandController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Brand
        public ActionResult Index()
        {
            var brands = _context.Brands.ToList();

            return View(brands);
        }

        public ActionResult AvailablePhones(int id)
        {
            var phones = _context.Phones
                            .Include(c => c.Brand)
                            .Include(c => c.PhoneType)
                            .Where(c => c.BrandId == id)
                            .ToList();


            return View(phones);

        }

        public ActionResult Details(int id)
        {
            var brand = _context.Brands
                .SingleOrDefault(c => c.ID == id);

            if (brand == null)
                return HttpNotFound();

            return View(brand);
        }

        public ActionResult New()
        {
            var brand = new Brand();


            return View("BrandForm", brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View("BrandForm", brand);
            }

            if (brand.ID == 0)
            {
                _context.Brands.Add(brand);
            }
            else
            {
                var brandInDB = _context.Brands.Single(b => b.ID == brand.ID);

                // Manually update the fields I want.
                brandInDB.BrandName = brand.BrandName;
                brandInDB.CountryOfOrigin = brand.CountryOfOrigin;
            }


            _context.SaveChanges();

            return RedirectToAction("Index", "Brand");
        }

        public ActionResult Edit(int id)
        {
            var brandInDB = _context.Brands.Single(m => m.ID == id);

            if (brandInDB == null)
                return HttpNotFound();

            return View("BrandForm", brandInDB);
        }

        public ActionResult Delete(int id)
        {
            var brandInDB = _context.Brands.Single(m => m.ID == id);

            _context.Brands.Remove(brandInDB);
            _context.SaveChanges();

            return RedirectToAction("Index", "Brand");
        }

    }
}