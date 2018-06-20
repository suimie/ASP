namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembership : DbMigration
    {
        public override void Up()
        {
            // This is pushing updates to my database
            Sql("UPDATE Memberships SET Name = 'Pay as you go' WHERE Id = 1 ");

            // Monthly
            Sql("UPDATE Memberships SET Name = 'Monthly' WHERE Id = 2 ");

            // Querterly
            Sql("UPDATE Memberships SET Name = 'Querterly' WHERE Id = 3 ");

            // Anual
            Sql("UPDATE Memberships SET Name = 'Anual' WHERE Id = 4 ");
        }

        public override void Down()
        {
        }
    }
}
