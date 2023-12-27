using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_test2.Controllers
{
    public class MaytinhController : Controller
    {
        // GET: Maytinh
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(double soA, double soB, char toantu) 
        {
            switch(toantu)
            {
                case '+': ViewBag.KetQua = soA + soB; break;
                case '-': ViewBag.KetQua = soA - soB; break;
                case '*': ViewBag.KetQua = soA * soB; break;
                case '/': ViewBag.KetQua = soA / soB; break;
            }
            return View("Index");
        }
    }
}