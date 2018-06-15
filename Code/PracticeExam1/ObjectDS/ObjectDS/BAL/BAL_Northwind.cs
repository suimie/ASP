using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ObjectDS.Data;

namespace ObjectDS.BAL
{
    public class BAL_Northwind
    {
        public List<string> getAllCountriesInCustomers()
        {
            using (var conext = new NorthwindDataContext())
            {
                List<string> coutriesList = (from data in conext.Customers
                                             select data.Country).Distinct().ToList();

                return coutriesList;
            }
        }

        public List<Customer> getAllCustomersByCountry(string country)
        {
            using (var conext = new NorthwindDataContext())
            {
                List<Customer> customersList = (from data in conext.Customers
                                                where data.Country == country
                                             select data).Distinct().ToList();

                return customersList;
            }
        }

        public Customer getCustomerByID(string customerID)
        {
            using (var conext = new NorthwindDataContext())
            {
                Customer customer = (from data in conext.Customers
                                    where data.CustomerID == customerID
                                     select data).Distinct().SingleOrDefault();

                return customer;
            }
        }

        public List<Order> getOrdersByOrderDate(DateTime orderDate)
        {
            using (var conext = new NorthwindDataContext())
            {
                List<Order> ordersList = (from data in conext.Orders
                                     where data.OrderDate == orderDate
                                     select data).ToList();

                return ordersList;
            }

        }

        public object getOrderDetailIncludeProductNameByOrderId(int orderId)
        {
            using (var conext = new NorthwindDataContext())
            {
                var orderDetail = (from od in conext.Order_Details
                                          join p in conext.Products
                                          on od.ProductID equals p.ProductID
                                          where od.OrderID == orderId
                                          select new { od.OrderID, od.ProductID, p.ProductName, od.Quantity, od.UnitPrice, od.Discount}).ToList();

                return orderDetail;
            }
        }
    }
}