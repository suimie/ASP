using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "Customer ID: " + ID + " | Name: " + Name;
        }
    }
}