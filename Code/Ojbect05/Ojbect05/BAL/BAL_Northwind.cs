using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ojbect05.Data;

namespace Ojbect05.BAL
{
    public class BAL_Northwind
    {
        /* Method to get countires from the Customers table.
         * 
         */
        public List<string> getCountries()
        {
            using (var context = new NorthWindDataContext())
            {
                List<string> countriesList = (from data in context.Customers
                                              select data.Country).Distinct().ToList();

                return countriesList;
            }
        }

        /* Unpon selection of a country, all customers from that country will be displayed
         * in the datagrid.
         * Method: will get all customers from a specific country
         */

        public List<Customer> getCustomersByCountry(string country)
        {
            using (var context = new NorthWindDataContext())
            {
                List<Customer> countriesList = (from data in context.Customers
                                              where data.Country == country
                                              select data).ToList();

                return countriesList;
            }
        }

        /* get a customer by customer ID
         */
        public Customer getCustomer(string customerID)
        {
            using (var context = new NorthWindDataContext())
            {
                Customer customer = (from data in context.Customers
                                     where data.CustomerID == customerID
                                     select data).SingleOrDefault();

                return customer;
            }
        }

        /* get orders list */
        public List<Order> getOrders(DateTime orderDate)
        {
            using (var context = new NorthWindDataContext())
            {
                List<Order> ordersList = (from data in context.Orders
                                     where data.OrderDate == orderDate
                                     select data).ToList();

                return ordersList;
            }
        }

        /* get order */
        public Order getOrder(D)
    }
}