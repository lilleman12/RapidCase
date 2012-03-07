using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RapidCase.GUI.Models;
using System.IO;
using System.Text.RegularExpressions;

namespace RapidCase.GUI.Controllers
{
    public class SetUpController : Controller
    {
        //
        // GET: /SetUp/

        public ActionResult Index()
        {
            SetupModel model = new SetupModel();
            model.DBLocation = "Localhost";
            model.DBPort = "8080";
            return View(model);
        }
       
        //
        // POST: /SetUp/Create

        [HttpPost]
        public ActionResult Index(SetupModel model)
        {            
            try
            {

                SetAppSettingValue("FirstTime", "False");
                SetAppSettingValue("DBLocation", model.DBLocation);
                SetAppSettingValue("DBPort", model.DBPort);
                SetAppSettingValue("AdministrationPassword", model.AdministratorPassword);
                return RedirectToAction("Index", "DevelopmentStudio");
            }
            catch
            {
                return View(model);
            }
        }

        public void SetAppSettingValue(string appSetting, string newValue)
        {
            
            string text;
            using (StreamReader reader = System.IO.File.OpenText(this.Server.MapPath("~/web.config")))
            {
                text = reader.ReadToEnd();
            }
            string appSettingReplaceString = "<add key=\"" + appSetting + "\" value=\"(.*)\" />";
            string appSettingNewValue = "<add key=\"" + appSetting + "\" value=\"" + newValue + "\" />";
            text = Regex.Replace(text, appSettingReplaceString, appSettingNewValue, RegexOptions.IgnoreCase);
            using (StreamWriter writer = new StreamWriter(System.IO.File.Create(this.Server.MapPath("~/web.config"))))
            {
                writer.Write(text);
            }
        }
    }
}
