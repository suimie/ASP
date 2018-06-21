namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //this is pushing updates to my database
            
            //Pay as you go
            Sql("INSERT INTO Memberships" +
                "(Id, SignUpFee, DurationInMonths, DiscountRate)" +
                " VALUES(1, 0, 0, 0)");

            //Monthly
            Sql("INSERT INTO Memberships" +
                "(Id, SignUpFee, DurationInMonths, DiscountRate)" +
                " VALUES(2, 10, 1, 10)");

            //Querterly
            Sql("INSERT INTO Memberships" +
                "(Id, SignUpFee, DurationInMonths, DiscountRate)" +
                " VALUES(3, 30, 3, 15)");

            //Anual
            Sql("INSERT INTO Memberships" +
                "(Id, SignUpFee, DurationInMonths, DiscountRate)" +
                " VALUES(4, 100, 12, 20)");

        }

        public override void Down()
        {
        }
    }
}
