using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopPhono.Models
{
    public class PhoneType
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public String Type { get; set; }

        [Required]
        [MaxLength(10)]
        public String OS { get; set; }

        public String Name
        {
            get
            {
                return Type + ", " + OS;
            }
        }
    }
}