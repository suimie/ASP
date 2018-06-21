namespace PhoneOnlineShop.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PhoneOnlineShop.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneOnlineShop.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PhoneOnlineShop.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Brands.RemoveRange(context.Brands);
            context.Phones.RemoveRange(context.Phones);

            IList<Brand> brands = new List<Brand>();

            brands.Add(new Brand()
            {
                BrandName = "Samsung",
                CountryOfOrigin = "Korea"
            });

            brands.Add(new Brand()
            {
                BrandName = "LG",
                CountryOfOrigin = "Korea"
            });

            brands.Add(new Brand()
            {
                BrandName = "Apple",
                CountryOfOrigin = "USA"
            });

            brands.Add(new Brand()
            {
                BrandName = "Huawei",
                CountryOfOrigin = "China"
            });


            IList<Phone> phones = new List<Phone>();

            phones.Add(new Phone()
            {
                PhoneName = "P20 Pro",
                BrandId = 4,
                DateRelease = DateTime.Parse("2018-01-05"),
                ScreenSize = 6.10m,
                PhoneTypeId = 1
            });

            phones.Add(new Phone()
            {
                PhoneName = "Galaxy S9",
                BrandId = 1,
                DateRelease = DateTime.Parse("2018-03-20"),
                ScreenSize = 9.70m,
                PhoneTypeId = 1
            });

            phones.Add(new Phone()
            {
                PhoneName = "iPhone X",
                BrandId = 3,
                DateRelease = DateTime.Parse("2017-09-04"),
                ScreenSize = 8.90m,
                PhoneTypeId = 2
            });

            phones.Add(new Phone()
            {
                PhoneName = "G7 THINQ",
                BrandId = 2,
                DateRelease = DateTime.Parse("2017-08-05"),
                ScreenSize = 6.09m,
                PhoneTypeId = 1
            });

            phones.Add(new Phone()
            {
                PhoneName = "Galaxy Note8",
                BrandId = 1,
                DateRelease = DateTime.Parse("2017-10-10"),
                ScreenSize = 8.90m,
                PhoneTypeId = 1
            });

            phones.Add(new Phone()
            {
                PhoneName = "iPhone 8",
                BrandId = 3,
                DateRelease = DateTime.Parse("2017-09-05"),
                ScreenSize = 8.90m,
                PhoneTypeId = 2
            });

            phones.Add(new Phone()
            {
                PhoneName = "Mate10 Pro",
                BrandId = 4,
                DateRelease = DateTime.Parse("2017-06-02"),
                ScreenSize = 8.40m,
                PhoneTypeId = 1
            });


            context.Brands.AddRange(brands);
            context.Phones.AddRange(phones);

            base.Seed(context);
        }

    }
}
