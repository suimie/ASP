using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidPlace.Models
{
    public class Media
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public MediaType MediaType { get; set; }
        [Required]
        public int MediaTypeId { get; set; }

        public Genre Genre { get; set; }
        [Required]
        public int GenreId { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public int NuInStock { get; set; }
    }
}