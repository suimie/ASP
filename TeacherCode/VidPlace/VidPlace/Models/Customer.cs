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

        [Required (ErrorMessage ="Please enter the customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name= "Address")]
        public string  address { get; set; }

        
        public bool IsSubscribedToNewsLetter { get; set; }

        public Membership Membership { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipId { get; set; }

        //? the question mark is used to make the datatime object null.
        [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }
        /*
        public override string ToString()
        {
            return "Customer ID: " + ID + " | Name: " + Name;
        }*/
    }
}