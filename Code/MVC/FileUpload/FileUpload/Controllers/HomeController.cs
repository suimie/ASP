using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UploadImage()
        {

            return View();
        }

        [HttpPost]
        public ActionResult UploadImage(ImageFile ojbImage)
        {

            foreach(var file in ojbImage.files)
            {
                if(file != null && file.ContentLength > 0)
                {
                    file.SaveAs(Path.Combine(Server.MapPath("/Image"), Guid.NewGuid() + Path.GetExtension(file.FileName)));
                }
            }
            return View();
        }
    }

    public class ImageFile
    {
        public List<HttpPostedFileBase> files { get; set; }
    }
}