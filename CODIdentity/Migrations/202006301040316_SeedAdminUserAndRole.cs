namespace CODIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdminUserAndRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'817985d2-4897-45bb-926f-5ffc02943ab8', N'CanAccessAdminDashboard');
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'424cd107-3ecd-4ada-b6d0-75f640d8b52a', N'mishelshaji@outlook.com', 0, N'ALXxmJ5kkTVFWEjNubmqxuzge+RtSLJF4lJX/Ho3q/Jq4XwXG0KMj3R552cOREXswQ==', N'c2bf1459-28ed-4813-af03-0fa4a1bdcecc', NULL, 0, 0, NULL, 1, 0, N'mishelshaji@outlook.com');
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'424cd107-3ecd-4ada-b6d0-75f640d8b52a', N'817985d2-4897-45bb-926f-5ffc02943ab8');");
        }
        
        public override void Down()
        {
        }
    }
}
