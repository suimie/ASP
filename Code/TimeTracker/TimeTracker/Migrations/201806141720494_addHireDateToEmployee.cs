namespace TimeTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addHireDateToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DateOfHire", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "DateOfHire");
        }
    }
}
