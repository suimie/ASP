using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ojbect05.Data;

namespace Ojbect05.BAL
{
    public class newDetail
    {
        public int OrderID;

        public int ProductID;

        public string ProductName;

        public decimal UnitPrice;

        public short Quantity;

        public float Discount;
    }

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

        /* get orders list by order date*/
        public List<Order> getOrdersByDate(DateTime orderDate)
        {
            using (var context = new NorthWindDataContext())
            {
                List<Order> ordersList = (from data in context.Orders
                                          where data.OrderDate == orderDate
                                          select data).ToList();

                return ordersList;
            }
        }

        /*
         * get order details
         */
        public object getOrderDetailsByOrderID(int orderId)
        {
//            int.TryParse(orderid, out int orderidVal);

            using (var context = new NorthWindDataContext())
            {
                var order_details =
                    (from data in context.Order_Details
                     join p in context.Products
                     on data.ProductID equals p.ProductID 
                     where data.OrderID == orderId
                     select new { data.OrderID, data.ProductID, p.ProductName, data.UnitPrice, data.Quantity, data.Discount}).ToList();


                return order_details;
            }
        }



        /* get orders list by customerID */
        public List<Order> getOrdersByCustomer(string customerID)
        {
            using (var context = new NorthWindDataContext())
            {
                List<Order> ordersList = (from data in context.Orders
                                          where data.CustomerID == customerID
                                          select data).ToList();

                return ordersList;
            }
        }
    }
}