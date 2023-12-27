using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Web_test2.Models;

namespace Web_test2.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send(MailInfor Model)
        {
            var mail = new SmtpClient("smtp.gmail.com", 25)
            {
                Credentials = new NetworkCredential("hoainam3183@gmail.com", "scuc bpjv iqdk kesi"),
                EnableSsl = true
            };

            var m = new MailMessage();
            m.From = new MailAddress(Model.From);
            m.ReplyToList.Add(Model.From);
            m.To.Add(new MailAddress(Model.To));
            m.Subject = Model.Subject;
            m.Body = Model.Body;

            mail.Send(m);
            ViewBag.Notif = "Email sent !";
            return View("Index");
        }
    }
}