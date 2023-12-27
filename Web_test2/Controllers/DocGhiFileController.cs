using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Web_test2.Controllers
{
    public class DocGhiFileController : Controller
    {
        // GET: DocGhiFile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(string masv, string hoten, double ? diemso)
        {
            try //doc ghi file nen dung try catch
            {
                var path = Server.MapPath("~/data.txt");
                string[] lines = { masv, hoten, diemso.ToString() };
                System.IO.File.WriteAllLines(path, lines);
                ViewBag.KetQua = "Ghi thành công !";
            }
            catch (Exception ex) 
            {
                ViewBag.KetQua = "Ghi thất bại";
            }
            return View("Index");
        }

        public ActionResult Open()
        {
            try
            {
                var path = Server.MapPath("~/data.txt");
                string[] lines = System.IO.File.ReadAllLines(path);
                ViewBag.masv = lines[0];
                ViewBag.hoten = lines[1];
                ViewBag.diemso = lines[2];
                ViewBag.KetQua = "Đọc thành công !";
            }
            catch
            {
                ViewBag.KetQua = "Đọc thất bại !";
            }
            return View("Index");
        }
    }
}