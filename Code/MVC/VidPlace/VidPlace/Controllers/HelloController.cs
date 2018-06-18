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

        public ActionResult HelloWorld()
        {
            return View("Index");
        }

        public string msg()
        {
            return "Hello World ...";
        }

        public ActionResult HelloError()
        {
            return View("Error");
        }

        //
        public Customer hellowCustomer()
        {
            Customer c = new Customer();
            c.ID = 1001;
            c.Name = "Berry Alan";

            return c;
        }

        [Route("hello/getCustomer")]
        public ActionResult getCustomer()
        {
            Customer c = new Customer();
            c.ID = 1001;
            c.Name = "Berry Alan";

            //ViewData["customer"] = c;
            ViewBag.customer = c;
            return View();
        }

        // Testing different action result
        public ActionResult ActionResultDemo()
        {
            //return Content("Hello world...  germany lost yesterday...");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("About", "Home");
            //return RedirectToAction("About", "Home", new { page = 1, sortBy = "name" });    // parameters in query string
            return RedirectToAction("random", "media", new { userName = "alex123" });
        }
    }
}