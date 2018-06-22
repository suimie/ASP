namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMediaType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MediaTypes (Name) VALUES('Movie')");
            Sql("INSERT INTO MediaTypes (Name) VALUES('TV Show')");
            Sql("INSERT INTO MediaTypes (Name) VALUES('Tutorial')");

        }

        public override void Down()
        {
        }
    }
}
