using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class VideoRentalStoreRepository
    {
        VideoRentalStoreDbContext context = new VideoRentalStoreDbContext();

        /* Get All Customers
         */
        public List<Customer> getAllCustomers()
        {
            List<Customer> customers = (from c in context.Customers
                                        select c).ToList();

            return customers;
        }

        /* Get a Customer by ID
         */
        public Customer getCustomerById(int id)
        {
            Customer customer = (from c in context.Customers
                                 where c.ID == id
                                 select c).SingleOrDefault();

            return customer;
        }

        public void updateCustomer(int id, string firstname, string lastname, string address, string phoneNumber)
        {
            var customer = (from c in context.Customers where c.ID == id select c).ToList();

            // If update customerId, it won't work.  Just return.
            if(customer.Count <= 0)
                return;

            Customer newCustomer = customer[0];
            newCustomer.FirstName = firstname;
            newCustomer.LastName = lastname;
            newCustomer.Address = address;
            newCustomer.PhoneNumber = phoneNumber;
            context.SaveChanges();
        }

        public List<Media> getMediasByTitle(string title)
        {
            List<Media> medias;

            if (title == null)
            {
                medias = (from m in context.Medias
                          select m).ToList();

            }
            else
            {
                medias = (from m in context.Medias
                          where m.Title.Contains(title)
                          select m).ToList();

            }

            return medias;
        }

        public List<Media> getMediasByTitle(List<string> titles)
        {
            List <Media> medias = (from m in context.Medias
                                   where titles.Any(s => m.Title.Contains(s))
                                   select m).ToList();

            return medias;
        }

        public void addRentalRecod(int cid, List<string>selectedMedias)
        {
            RentalRecord newRR = new RentalRecord();
            newRR.RentalDate = DateTime.Now;
            newRR.RentedMedias = getMediasByTitle(selectedMedias);

            Customer customer = getCustomerById(cid);
            if (customer.RentalRecords == null)
                customer.RentalRecords = new List<RentalRecord>();
            customer.RentalRecords.Add(newRR);

            context.SaveChanges();
        }

        public void addNewCustomer(string firstname, string lastname, string address, string phoneNumber)
        {
            Customer customer = new Customer();
            customer.FirstName = firstname;
            customer.LastName = lastname;
            customer.Address = address;
            customer.PhoneNumber = phoneNumber;

            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void addNewMedia(string title, MediaType type, int year)
        {
            Media media = new Media();
            media.Title = title;
            media.Type = type;
            media.ProductionYear = year;

            context.Medias.Add(media);
            context.SaveChanges();
        }

    }
}