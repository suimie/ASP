using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PhoneOnlineShop.Models;

namespace PhoneOnlineShop.ViewModel
{
    public class PhoneFormViewModel
    {
        public Phone Phone;
        public IEnumerable<Brand> Brands;
        public IEnumerable<PhoneType> PhoneTypes;
    }
}