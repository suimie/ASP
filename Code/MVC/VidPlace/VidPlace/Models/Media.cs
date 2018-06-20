using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Media
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public MediaType MediaType { get; set; }
        public int? MediaTypeId { get; set; }

        public Genre Genre { get; set; }
        public int? GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NuInStock { get; set; }
    }
}