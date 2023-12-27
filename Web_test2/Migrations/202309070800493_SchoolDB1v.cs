namespace Web_test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolDB1v : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Grade_GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "Grade_GradeId" });
            AddColumn("dbo.Grades", "StudentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Grades", "StudentID");
            AddForeignKey("dbo.Grades", "StudentID", "dbo.Students", "StudentID", cascadeDelete: true);
            DropColumn("dbo.Students", "Grade_GradeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Grade_GradeId", c => c.Int());
            DropForeignKey("dbo.Grades", "StudentID", "dbo.Students");
            DropIndex("dbo.Grades", new[] { "StudentID" });
            DropColumn("dbo.Grades", "StudentID");
            CreateIndex("dbo.Students", "Grade_GradeId");
            AddForeignKey("dbo.Students", "Grade_GradeId", "dbo.Grades", "GradeId");
        }
    }
}
