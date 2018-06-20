namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMediaTypeGenreToMedia1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Media SET MediaTypeId = 1, GenreId=2 WHERE Id = 1 ");
            Sql("UPDATE Media SET MediaTypeId = 3, GenreId=1 WHERE Id = 2 ");
            Sql("UPDATE Media SET MediaTypeId = 2, GenreId=6 WHERE Id = 3 ");
            Sql("UPDATE Media SET MediaTypeId = 1, GenreId=5 WHERE Id = 4 ");
            Sql("UPDATE Media SET MediaTypeId = 1, GenreId=4 WHERE Id = 5 ");
            Sql("UPDATE Media SET MediaTypeId = 3, GenreId=2 WHERE Id = 6 ");
        }

        public override void Down()
        {
        }
    }
}
