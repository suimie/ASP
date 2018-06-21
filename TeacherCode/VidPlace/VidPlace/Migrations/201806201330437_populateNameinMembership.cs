namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateNameinMembership : DbMigration
    {
        public override void Up()
        {
            //updating memberships table Name column.
            //this is a part of the application business logic.
            Sql("UPDATE Memberships SET Name = 'Pay as you go' WHERE Id = 1");
            Sql("UPDATE Memberships SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE Memberships SET Name = 'Querterly' WHERE Id = 3");
            Sql("UPDATE Memberships SET Name = 'Annual' WHERE Id = 4");

        }

        public override void Down()
        {
        }
    }
}
