using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        // GET: Hello
        public ActionResult HelloWorld()
        {
            return View("Index");
        }

        public string msg()
        {
            return "Hello world.. Demo 2";
        }

        // GET: Hello
        public ActionResult helloError()
        {
            return View("Error");
        }

        //
        public Customer helloCustomer()
        {
            Customer c = new Customer();
            c.ID = 1001;
            c.Name = "Berry Alan";

            return c;
        }

        public ActionResult getCustomer()
        {
            Customer c = new Customer();
            c.ID = 1001;
            c.Name = "Berry Alan";

            //ViewData["customer"] = c;
            ViewBag.customer = c;
            return View();
        }

        //Testing different action result returns
        public ActionResult ActionResultDemo()
        {
            //return Content("Hello world... germany lost yestday .. yaay");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("About", "Home");
            //return RedirectToAction("About", "Home", new { page = 1, sortBy = "name" });
            return RedirectToAction("random", "media", new { userName="alex123" });
        }

    }
}