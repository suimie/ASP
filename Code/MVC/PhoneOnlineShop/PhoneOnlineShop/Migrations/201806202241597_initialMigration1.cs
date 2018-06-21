namespace PhoneOnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(nullable: false, maxLength: 255),
                        CountryOfOrigin = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhoneName = c.String(nullable: false, maxLength: 255),
                        BrandId = c.Int(nullable: false),
                        DateRelease = c.DateTime(nullable: false),
                        ScreenSize = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PhoneTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.PhoneTypes", t => t.PhoneTypeId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.PhoneTypeId);
            
            CreateTable(
                "dbo.PhoneTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                        OS = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "PhoneTypeId", "dbo.PhoneTypes");
            DropForeignKey("dbo.Phones", "BrandId", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "PhoneTypeId" });
            DropIndex("dbo.Phones", new[] { "BrandId" });
            DropTable("dbo.PhoneTypes");
            DropTable("dbo.Phones");
            DropTable("dbo.Brands");
        }
    }
}
