using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopPhono.Models
{
    public class Phone
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public String PhoneName { get; set; }

        public Brand Brand { get; set; }
        [Required]
        public int BrandId { get; set; }

        [Required(ErrorMessage ="Date released is required.")]
        public DateTime DateRelease { get; set; }

        [Required]
        [Range(2, 7, ErrorMessage = "The range of screen size is 2 - 7")]
        public decimal ScreenSize { get; set; }

        public PhoneType PhoneType { get; set; }

        [Required]
        public int PhoneTypeId { get; set; }
    }
}