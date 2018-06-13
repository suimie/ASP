using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObjectDS.Data;

namespace ObjectDS.BAL
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
                List<string> countries = (from data in context.Customers
                                select data.Country).Distinct().ToList();


                return countries;
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
                List<Customer> customers = (from data in context.Customers
                                            where data.Country == country
                                          select data).ToList();


                return customers;
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

        /* get orders list by order date*/
        public List<Order> getOrdersByOrderDate(DateTime orderDate)
        {
            using (var context = new NorthWindDataContext())
            {
                List<Order> orders = (from data in context.Orders
                                        where data.OrderDate == orderDate
                                        select data).ToList();


                return orders;
            }
        }

        
        /*
         * get order details
         */
        public List<Order_Detail> getOrderDetailsByOrderID(string orderid)
        {
            int.TryParse(orderid, out int orderidVal);

            using (var context = new NorthWindDataContext())
            {
                List<Order_Detail> order_details =
                    (from data in context.Order_Details
                     where data.OrderID == orderidVal
                     select data).ToList();


                return order_details;
            }
        }

        /* get orders list by customerID 
         *
         */
        public List<Order> getOrdersByCustomer(string customerId)
        {
            using (var context = new NorthWindDataContext())
            {
                List<Order> orders = (from data in context.Orders
                                      where data.CustomerID == customerId
                                      select data).ToList();


                return orders;
            }
        }
    }
}