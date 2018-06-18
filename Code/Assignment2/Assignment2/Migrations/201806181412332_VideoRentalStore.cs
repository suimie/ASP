namespace Assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VideoRentalStore : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RentalRecords",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RentalDate = c.DateTime(nullable: false),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Type = c.Int(nullable: false),
                        ProductionYear = c.Int(nullable: false),
                        RentalRecord_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RentalRecords", t => t.RentalRecord_ID)
                .Index(t => t.RentalRecord_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentalRecords", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Media", "RentalRecord_ID", "dbo.RentalRecords");
            DropIndex("dbo.Media", new[] { "RentalRecord_ID" });
            DropIndex("dbo.RentalRecords", new[] { "Customer_ID" });
            DropTable("dbo.Media");
            DropTable("dbo.RentalRecords");
            DropTable("dbo.Customers");
        }
    }
}
