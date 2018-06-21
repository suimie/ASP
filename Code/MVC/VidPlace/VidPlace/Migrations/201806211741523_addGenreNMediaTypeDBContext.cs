namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenreNMediaTypeDBContext : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Media", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Media", "MediaTypeId", "dbo.MediaTypes");
            DropIndex("dbo.Media", new[] { "MediaTypeId" });
            DropIndex("dbo.Media", new[] { "GenreId" });
            AlterColumn("dbo.Media", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Media", "MediaTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Media", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Media", "MediaTypeId");
            CreateIndex("dbo.Media", "GenreId");
            AddForeignKey("dbo.Media", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Media", "MediaTypeId", "dbo.MediaTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Media", "MediaTypeId", "dbo.MediaTypes");
            DropForeignKey("dbo.Media", "GenreId", "dbo.Genres");
            DropIndex("dbo.Media", new[] { "GenreId" });
            DropIndex("dbo.Media", new[] { "MediaTypeId" });
            AlterColumn("dbo.Media", "GenreId", c => c.Int());
            AlterColumn("dbo.Media", "MediaTypeId", c => c.Int());
            AlterColumn("dbo.Media", "Name", c => c.String());
            CreateIndex("dbo.Media", "GenreId");
            CreateIndex("dbo.Media", "MediaTypeId");
            AddForeignKey("dbo.Media", "MediaTypeId", "dbo.MediaTypes", "Id");
            AddForeignKey("dbo.Media", "GenreId", "dbo.Genres", "Id");
        }
    }
}
