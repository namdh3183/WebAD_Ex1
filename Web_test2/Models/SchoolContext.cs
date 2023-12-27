using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_test2.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDBConString")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}