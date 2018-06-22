namespace OnlineShopPhono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePhoneType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PhoneTypes (Type, OS) VALUES('Smart', 'Android')");
            Sql("INSERT INTO PhoneTypes (Type, OS) VALUES('Smart', 'iOS')");
            Sql("INSERT INTO PhoneTypes (Type, OS) VALUES('Bar', 'NA')");
            Sql("INSERT INTO PhoneTypes (Type, OS) VALUES('Flip', 'NA')");
        }

        public override void Down()
        {
        }
    }
}
