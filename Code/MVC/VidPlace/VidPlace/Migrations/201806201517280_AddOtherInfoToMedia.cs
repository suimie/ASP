namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOtherInfoToMedia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Media", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Media", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Media", "NuInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Media", "NuInStock");
            DropColumn("dbo.Media", "DateAdded");
            DropColumn("dbo.Media", "ReleaseDate");
        }
    }
}
