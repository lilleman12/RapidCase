using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace RapidCase.GUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (ApplicationStartedForTheFirstTime())
            {
                return this.RedirectToAction("Index", "SetUp");
            }

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        private bool ApplicationStartedForTheFirstTime()
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["FirstTime"]))
            {
                return true;
            }
            return false;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
