namespace Web_test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolDB1v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grades", "Score", c => c.Double(nullable: false));
            DropColumn("dbo.Grades", "Section");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Grades", "Section", c => c.String());
            DropColumn("dbo.Grades", "Score");
        }
    }
}
