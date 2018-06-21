using PhoneOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;

namespace PhoneOnlineShop.Controllers
{
    public class PhoneController : Controller
    {
        //DBContext Object
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

            return View(phone);
        }

    }
}