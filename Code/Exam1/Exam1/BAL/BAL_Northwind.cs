using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Exam1.Data;

namespace Exam1.BAL
{
    public class BAL_Northwind
    {
        /* get all suupliers list
         */
        public List<Supplier> getSuppliersList()
        {
            using (var conext = new NorthwindDataContext())
            {
                List<Supplier> suppliersList = (from s in conext.Suppliers
                                    select s).ToList();

                return suppliersList;
            }
        }

        /* get suppliers list using city string
         */
        public List<Supplier> getSuppliersListByCity(string city)
        {
            using (var conext = new NorthwindDataContext())
            {
                List<Supplier> suppliersList = (from s in conext.Suppliers
                                                where s.City == city
                                                select s).ToList();

                return suppliersList;
            }
        }
    }
}