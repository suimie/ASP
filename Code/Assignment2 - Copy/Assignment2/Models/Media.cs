using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public enum MediaType { Movies, TVShow, Others };
    public class Media
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public MediaType Type { get; set; }
        public int ProductionYear { get; set; }
    }
}