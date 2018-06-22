namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSeedAccount : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a9de165a-100d-43d3-8011-52f431055ade', N'guest@vidplace.com', 0, N'AFB+MJyZzOIMOKRv5K/FXdpDptogki8GLQpDg9AYRjv+1Kk3ZLw6yjEQYnsjnH9n5w==', N'91292c6c-547d-4d8f-859c-45c0bd337625', NULL, 0, 0, NULL, 1, 0, N'guest@vidplace.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bfe70730-866b-4ea7-9bb2-3dce19c488c5', N'admin@vidplace.com', 0, N'AAmvi2/vDswJ3rFhhKN4kjgjo66hDIz3uVhGUL7di7YiC9kd+VzM1GeYBwDJqqcrIA==', N'2b96cabc-d96c-4735-a7f5-203d70bb0e0a', NULL, 0, 0, NULL, 1, 0, N'admin@vidplace.com')");

            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cc6d067f-0f54-44e6-aef5-bed026f701cc', N'CanManageMedia')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bfe70730-866b-4ea7-9bb2-3dce19c488c5', N'cc6d067f-0f54-44e6-aef5-bed026f701cc')");
        }
        
        public override void Down()
        {
        }
    }
}
