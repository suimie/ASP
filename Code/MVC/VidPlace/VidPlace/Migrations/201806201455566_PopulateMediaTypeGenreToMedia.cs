namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMediaTypeGenreToMedia : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Media", name: "Genre_Id", newName: "GenreId");
            RenameColumn(table: "dbo.Media", name: "MediaType_Id", newName: "MediaTypeId");
            RenameIndex(table: "dbo.Media", name: "IX_MediaType_Id", newName: "IX_MediaTypeId");
            RenameIndex(table: "dbo.Media", name: "IX_Genre_Id", newName: "IX_GenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Media", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameIndex(table: "dbo.Media", name: "IX_MediaTypeId", newName: "IX_MediaType_Id");
            RenameColumn(table: "dbo.Media", name: "MediaTypeId", newName: "MediaType_Id");
            RenameColumn(table: "dbo.Media", name: "GenreId", newName: "Genre_Id");
        }
    }
}
