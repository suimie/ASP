using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PhoneOnlineShop.Models;
using System.Data.Entity;

namespace PhoneOnlineShop.Controllers
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
    }
}