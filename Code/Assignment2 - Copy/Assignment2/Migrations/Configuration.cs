namespace Assignment2.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Assignment2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2.Models.VideoRentalStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment2.Models.VideoRentalStoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Customers.RemoveRange(context.Customers);
            context.Medias.RemoveRange(context.Medias);
            context.RentalRecords.RemoveRange(context.RentalRecords);

            IList<Customer> customers = new List<Customer>();

            customers.Add(new Customer()
            {
                ID = 1,
                FirstName = "Maria",
                LastName = "Anders",
                Address = "Obere Str. 57",
                PhoneNumber = "030-0076545",
                RentalRecords = new List<RentalRecord>
                {
                    new RentalRecord
                    {
                        ID = 1,
                        RentalDate = DateTime.Now.AddDays(-30),
                        RentedMedias = new List<Media>
                        {
                            new Media{ ID=1, ProductionYear=2013, Title="Orange is the new black", Type=MediaType.TVShow }
                        }
                    }
                }
            });

            customers.Add(new Customer()
            {
                ID = 2,
                FirstName = "Ana",
                LastName = "Trujillo",
                Address = "Avda. de la Constitución 2222",
                PhoneNumber = "(5) 555-4729",
                RentalRecords = new List<RentalRecord>
                {
                    new RentalRecord
                    {
                        ID = 2,
                        RentalDate = DateTime.Now.AddDays(-20),
                        RentedMedias = new List<Media>
                        {
                            new Media{ ID=2, ProductionYear=2016, Title="Doctor Strange", Type=MediaType.Movies }
                        }
                    }
                }
            });
            //context.Customers.AddRange(customers);
            //base.Seed(context);

        }
    }
}

