using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sc = WebApplication_mail.Models.SmallCase;
using ai = WebApplication_mail.Models.MailAccountMng;

namespace WebApplication_mail.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Hello()
        {
            var h = new sc.HelloWorld();
            ViewBag.hello = h.Text;
          
            return View();
        }

        public ActionResult AddInfo()
        {
            var h = new ai.MailAdd();
            ViewBag.hello = h.A;

            return View();
        }

    }
}