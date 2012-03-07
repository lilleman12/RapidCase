using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RapidCase.GUI.Controllers
{
    public class DevelopmentStudioController : Controller
    {
        //
        // GET: /DeveloperStudio/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /DeveloperStudio/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DeveloperStudio/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DeveloperStudio/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /DeveloperStudio/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DeveloperStudio/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /DeveloperStudio/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DeveloperStudio/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
