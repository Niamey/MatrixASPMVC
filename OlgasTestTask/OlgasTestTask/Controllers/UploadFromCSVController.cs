using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OlgasTestTask.Controllers
{
    public class UploadFromCSVController : Controller
    {
        // GET: UploadFromCSV
        public ActionResult Index()
        {
            return View();
        }

      

        // GET: UploadFromCSV/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UploadFromCSV/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UploadFromCSV/Create
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

        // GET: UploadFromCSV/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UploadFromCSV/Edit/5
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

        // GET: UploadFromCSV/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UploadFromCSV/Delete/5
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
