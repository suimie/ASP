using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneOnlineShop.Models
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