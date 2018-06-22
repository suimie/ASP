namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMemberships : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Memberships " +
                "(Id, Name, SignUpFee, DurationInMonths, DiscountRate) " +
                "VALUES(1, 'Pay as you go', 0, 0, 0)");

            // Monthly
            Sql("INSERT INTO Memberships " +
                "(Id, Name, SignUpFee, DurationInMonths, DiscountRate) " +
                "VALUES(2, 'Monthly', 10, 1, 10)");

            // Querterly
            Sql("INSERT INTO Memberships " +
                "(Id, Name, SignUpFee, DurationInMonths, DiscountRate) " +
                "VALUES(3, 'Querterly', 30, 3, 15)");

            // Anual
            Sql("INSERT INTO Memberships " +
                "(Id, Name, SignUpFee, DurationInMonths, DiscountRate) " +
                "VALUES(4, 'Anual', 100, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
