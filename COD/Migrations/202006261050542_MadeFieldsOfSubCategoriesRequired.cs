namespace COD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeFieldsOfSubCategoriesRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SubCategories", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubCategories", "Name", c => c.String());
        }
    }
}
