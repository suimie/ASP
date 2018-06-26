namespace SurveyOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTopics : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics (Id, Name) VALUES(1, 'IT')");

            Sql("INSERT INTO Topics (Id, Name) VALUES(2, 'Science')");

            Sql("INSERT INTO Topics (Id, Name) VALUES(3, 'Social and Other')");
        }

        public override void Down()
        {
        }
    }
}
