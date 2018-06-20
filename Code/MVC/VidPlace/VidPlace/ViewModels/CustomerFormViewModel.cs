﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.ViewModels
{
    public class CustomerFormViewModel 
    {
        public Customer Customer { get; set; }
        public IEnumerable<Membership> Memberships { get; set; }
    }
}