namespace Web_test2.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Web_test2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web_test2.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Web_test2.Models.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            base.Seed(context);
            var lstStudent = new List<Student>();
            lstStudent.Add(new Student() { StudentName = "sahfdtj"});
            lstStudent.Add(new Student() { StudentName = "sfgsfdsrhgfs"});
            lstStudent.Add(new Student() { StudentName = "safjyhdtrsghgrefagstj"});
            lstStudent.ForEach(s => context.Students.AddOrUpdate(s));

            var lstScore = new List<Grade>();
            lstScore.Add(new Grade() { GradeName = "sgrfdvs", Score = 9, StudentID = 1 });
            lstScore.Add(new Grade() { GradeName = "fghdgt", Score = 8, StudentID = 1 });
            lstScore.Add(new Grade() { GradeName = "JGVy", Score = 4, StudentID = 1 });
            lstScore.Add(new Grade() { GradeName = "sgrfdvs", Score = 8, StudentID = 2 });
            lstScore.Add(new Grade() { GradeName = "fghdgt", Score = 9, StudentID = 2 });
            lstScore.Add(new Grade() { GradeName = "JGVy", Score = 6, StudentID = 2 });
            lstScore.ForEach(s => context.Grades.AddOrUpdate(s));

        }
    }
}
