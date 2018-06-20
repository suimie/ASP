namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDateInfoToMedia : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Media SET ReleaseDate = '2017-05-11', DateAdded='2018-05-30' WHERE Id = 1 ");
            Sql("UPDATE Media SET ReleaseDate = '2016-04-21', DateAdded='2018-01-20' WHERE Id = 2 ");
            Sql("UPDATE Media SET ReleaseDate = '2000-01-01', DateAdded='2017-02-11' WHERE Id = 3 ");
            Sql("UPDATE Media SET ReleaseDate = '2008-12-14', DateAdded='2018-01-30' WHERE Id = 4 ");
            Sql("UPDATE Media SET ReleaseDate = '2007-03-17', DateAdded='2011-02-10' WHERE Id = 5 ");
            Sql("UPDATE Media SET ReleaseDate = '2018-08-21', DateAdded='2018-06-10' WHERE Id = 6 ");

        }

        public override void Down()
        {
        }
    }
}
