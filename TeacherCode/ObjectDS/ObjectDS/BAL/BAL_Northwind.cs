using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObjectDS.Data;

namespace ObjectDS.BAL
{
    public class BAL_Northwind
    {
        /* Method to get countries from the Customers table.
         */
        public List<string> getCountries()
        {
            using (var conext = new NorthwindDataContext())
            {
                List<string> coutriesList = (from data in conext.Customers
                                             select data.Country).Distinct().ToList();

                return coutriesList;
            }
        }

        /*Upon selection of a country, all customers from that country will be displayed
         * in the datagrid.
         * 
         * Method: will get all customers from a specific country
         */
        public List<Customer> getCustomersByCountry(string country)
        {
            using (var conext = new NorthwindDataContext())
            {
                List<Customer> customerList = (from data in conext.Customers
                                               where data.Country == country
                                             select data).ToList();

                return customerList;
            }
        }

        /*get a customer by customer ID
         * 
         */
        public Customer getCustomer(string customerID)
        {
            using (var conext = new NorthwindDataContext())
            {
                Customer customer = (from data in conext.Customers
                                     where data.CustomerID == customerID
                                     select data).SingleOrDefault();

                return customer;
            }
        }
    }
}