using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Generator;

namespace Web_test2.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            var image = Request.Files["image"];
            var document = Request.Files["document"];
            var path = Server.MapPath("~/UploadFiles/");

            if(image != null && image.ContentLength > 0) 
            {
                image.SaveAs(path + image.FileName);
                ViewBag.FileNameImage = image.FileName;
            }
            if (document != null && document.ContentLength > 0)
            {
                document.SaveAs(path + document.FileName);
                ViewBag.FileName = document.FileName;
                ViewBag.FileType = document.ContentType;
                ViewBag.FileSize = document.ContentLength;
            }
            return View();
        }
    }
}