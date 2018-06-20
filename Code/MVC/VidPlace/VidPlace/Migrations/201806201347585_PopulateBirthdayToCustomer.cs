namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '2000-01-05' WHERE Id = 1 ");
            Sql("UPDATE Customers SET Birthday = '1980-06-15' WHERE Id = 3 ");
            Sql("UPDATE Customers SET Birthday = '2003-09-19' WHERE Id = 5 ");

        }

        public override void Down()
        {
        }
    }
}
