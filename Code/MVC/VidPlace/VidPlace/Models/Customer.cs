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

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }// = false;
        public Membership Membership { get; set; }
        public byte MembershipId { get; set; }

        /*
        public override string ToString()
        {
            return "Customer ID: " + ID + " | Name: " + Name;
        }*/
    }
}