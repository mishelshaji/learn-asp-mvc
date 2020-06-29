namespace COD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Categories] ON
            INSERT INTO [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Programming')
            INSERT INTO [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Comedy')
            SET IDENTITY_INSERT [dbo].[Categories] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
