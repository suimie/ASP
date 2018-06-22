using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopPhono.Models
{
    public class Brand
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public String BrandName { get; set; }

        public String CountryOfOrigin { get; set; }
    }
}