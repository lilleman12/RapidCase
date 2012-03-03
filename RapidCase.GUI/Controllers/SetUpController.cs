using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RapidCase.GUI.Controllers
{
    public class SetUpController : Controller
    {
        //
        // GET: /SetUp/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /SetUp/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SetUp/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SetUp/Create

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
        // GET: /SetUp/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SetUp/Edit/5

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
        // GET: /SetUp/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SetUp/Delete/5

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
