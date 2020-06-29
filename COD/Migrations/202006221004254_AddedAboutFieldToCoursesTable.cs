namespace COD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAboutFieldToCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "About", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "About");
        }
    }
}
