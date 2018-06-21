namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReleaseDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Media", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Media", "ReleaseDate");
        }
    }
}
