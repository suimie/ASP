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
    public class MediaController : Controller
    {
        //DBContext Object
        private ApplicationDbContext _context;

        public MediaController()
        {
            _context = new ApplicationDbContext();
        }

        
        //GET: Media/Index
        public ActionResult Index()
        {
            //var media = GetMedias();
            var media = _context.Medias.Include(m=>m.Genre).ToList();
            return View(media);
        }

        public ActionResult Details(int id)
        {
            var media = _context.Medias
                .Include(m => m.Genre)
                .Include(m => m.MediaType)
                .SingleOrDefault(m => m.ID == id);
            if (media == null)
                return HttpNotFound();
            else
            {
                return View(media);
            }

        }

        private IEnumerable<Media> GetMedias()
        {
            return new List<Media>()
            {
                new Media(){ID = 1, Name = "Shrek"},
                new Media(){ID = 1, Name = "The 100"},
            };
        }

        [Route("media/released/{year:range(2000,2020)}/{month:range(1,12)}")]
        public ActionResult released(int year, int month)
        {
            return Content("Year = " + year + ", Month = " + month);
        }

        

        public ActionResult edit(int mediaID)
        {
            return Content("Provided ID = " + mediaID);
        }

        public ActionResult random()
        {
            var media = new Media();

            media.Name = "Ocean 8";
            media.ID = 2002;

            return View(media);
        }

        public ActionResult rentals()
        {
            var media = new Media() { Name = "Avengers" };
            var customers = new List<Customer>
            {
                new Customer(){Name = "Thomas Edison"}
                //new Customer(){Name = "Alex ABC"},
                //new Customer(){Name = "Sue Smith"}
            };

            var viewModel = new RentalsMediaViewModel()
            {
                Media = media,
                Customers = new List<Customer>() //customers
            };

            return View(viewModel);
        }

        // GET: Media
        /*public ActionResult Index()
        {
            return View();
        }*/
        /*
        [Route("media/index/{PageIndex:range(1,100)}/{sortby?}")]
        public ActionResult Index(int? PageIndex, string sortby)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortby))
                sortby = "name";

            return Content("Page # " + PageIndex + " | Sort by: " + sortby);
        }*/

    }
}