namespace COD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCoursesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        Cost = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
