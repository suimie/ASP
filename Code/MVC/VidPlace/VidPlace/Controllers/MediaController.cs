using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using VidPlace.Models;
using VidPlace.ViewModels;

namespace VidPlace.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        /*public ActionResult Index()
        {
            return View();
        }*/

        //       [Route("media/index/{PageIndex:range(1,1000)}/{sortby:maxlength(4)}")]
        /*
        [Route("media/index/{PageIndex?}/{sortby?}")]
        public ActionResult Index(int? PageIndex, string sortby)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortby))
                sortby = "name";

            return Content("Page # " + PageIndex + " | Sort By: " + sortby);
        }*/

        // GET: Media/Index
        public ActionResult Index()
        {
            
            return View(getMedias());
        }

        public IEnumerable<Media> getMedias()
        {
            var medias = new List<Media>
            {
                new Media() {  ID=1, Name="Avengers" },
                new Media() {  ID=2, Name="ABC" }
            };

            return medias;
        }


        public ActionResult random()
        {
            var media = new Media();

            media.Name = "Ocean 8";
            media.ID = 2002;

            return View(media);
        }

        public ActionResult edit(int ID)
        {
            // http://localhost:62632/media/edit?id=123
            // http://localhost:62632/media/edit/123
            return Content("Provided ID = " + ID);
        }

        [Route("media/released/{year:range(2017,2018)}/{month:range(1,12)}")]
        public ActionResult released(int year, int month)
        {
            return Content("Released in Year = " + year + ", Month = " + month);
        }

        public ActionResult rentals()
        {
            var media = new Media() { Name="Avengers"};
            var customer = new List<Customer>
            {
                //new Customer() { Name = "Thomas Edison" },
                //new Customer() { Name = "Alex ABC" },
                //new Customer() { Name = "Sue Smith" }
            };

            var viewModels = new RentalsMediaViewModel()
            {
                Media = media,
                Customers = customer
            };

            return View(viewModels);
        }

    }
}