﻿using System;
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
        private ApplicationDbContext _context;

        public MediaController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Media/Index
        public ActionResult Index()
        {
            var medias = _context.Medias
                .Include(c => c.Genre)
                .Include(c => c.MediaType)
                .ToList();
            return View(medias);
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

        public ActionResult Details(int id)
        {
            var medias = _context.Medias
                .Include(c => c.MediaType)
                .Include(c => c.Genre)
                .SingleOrDefault(c => c.ID == id);
            if (medias == null)
                return HttpNotFound();
            else
                return View(medias);
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