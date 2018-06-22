using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneOnlineShop.Models
{
    public class PhoneType
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public String Type { get; set; }

        [Required]
        [MaxLength(10)]
        public String OS { get; set; }

        public String Name {
            get
            {
                return Type + ", " + OS;
            }
        }
    }
}