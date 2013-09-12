using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSampleWebApp.Models;

namespace MvcSampleWebApp.Controllers
{
    public class PrintJobsController : Controller
    {
        private PrintJobDBContext db = new PrintJobDBContext();

        //
        // GET: /PrintJobs/
        [Authorize]
        public ActionResult Index()
        {
            return View(db.PrintJobs.ToList());
        }

        //
        // GET: /PrintJobs/Details/5

        public ActionResult Details(int id = 0)
        {
            PrintJob printjob = db.PrintJobs.Find(id);
            if (printjob == null)
            {
                return HttpNotFound();
            }
            return View(printjob);
        }

        //
        // GET: /PrintJobs/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PrintJobs/Create

        [HttpPost]
        public ActionResult Create(PrintJob printjob)
        {
            if (ModelState.IsValid)
            {
                db.PrintJobs.Add(printjob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(printjob);
        }

        //
        // GET: /PrintJobs/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PrintJob printjob = db.PrintJobs.Find(id);
            if (printjob == null)
            {
                return HttpNotFound();
            }
            return View(printjob);
        }

        //
        // POST: /PrintJobs/Edit/5

        [HttpPost]
        public ActionResult Edit(PrintJob printjob)
        {
            if (ModelState.IsValid)
            {
                db.Entry(printjob).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(printjob);
        }

        //
        // GET: /PrintJobs/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PrintJob printjob = db.PrintJobs.Find(id);
            if (printjob == null)
            {
                return HttpNotFound();
            }
            return View(printjob);
        }

        //
        // POST: /PrintJobs/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PrintJob printjob = db.PrintJobs.Find(id);
            db.PrintJobs.Remove(printjob);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}