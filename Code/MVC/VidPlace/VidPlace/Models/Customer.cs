using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace VidPlace.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Date of birth")]
        [Min18YearsIfMember]
        public DateTime? Birthday { get; set; } = null;

        [Required(ErrorMessage = "Please enter the cutomer's name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }// = false;
        public Membership Membership { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipId { get; set; }

        /*
        public override string ToString()
        {
            return "Customer ID: " + ID + " | Name: " + Name;
        }*/
    }
}