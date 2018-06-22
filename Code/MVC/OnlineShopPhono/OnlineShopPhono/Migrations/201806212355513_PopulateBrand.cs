namespace OnlineShopPhono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBrand : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES('Samsung', 'Korea')");
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES('LG', 'Korea')");
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES('Apple', 'USA')");
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES('Huawei', 'China')");

        }

        public override void Down()
        {
        }
    }
}
