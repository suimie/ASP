using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneOnlineShop.Models
{
    public class Phone
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public String PhoneName { get; set; }

        [Required]
        public Brand Brand { get; set; }
        [Required]
        public int BrandId { get; set; }

        [Required]
        public DateTime DateRelease { get; set; }

        [Required]
        [Range(2, 7, ErrorMessage ="The range of screen size is 2 - 7")]
        public decimal ScreenSize { get; set; }

        [Required]
        public PhoneType PhoneType { get; set; }

        [Required]
        public int PhoneTypeId { get; set; }
    }
}