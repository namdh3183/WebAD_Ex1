using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_test2.Models;

namespace Web_test2.Controllers
{
    public class GradeController : Controller
    {
        SchoolContext db = new SchoolContext();
        // GET: Grade
        public ActionResult Index()
        {
            var result = from s in db.Grades
                         where s.Score >= 9
                         //join 
                         select new { StudentName = s.Student.StudentName, GradeName = s.GradeName, Score = s.Score };
            return View(result);
        }
    }
}