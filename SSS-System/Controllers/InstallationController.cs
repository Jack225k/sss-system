using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SSS_System.Models;

namespace SSS_System.Controllers
{
    public class InstallationController : Controller
    {
        private ApplicationDbContext db;

        public InstallationController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Installations
        public ActionResult Index()
        {
            return View(db.Installations.ToList());
        }

        // GET: Installations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Installation installation = db.Installations.Find(id);
            if (installation == null)
            {
                return HttpNotFound();
            }
            return View(installation);
        }

        // GET: Installations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Installations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Installation installation)
        {

            DateTime datecreated2 = DateTime.Now;

            if (ModelState.IsValid)
            {
                installation.Date = datecreated2;
                db.Installations.Add(installation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(installation);
        }

        // GET: Installations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Installation installation = db.Installations.Find(id);
            if (installation == null)
            {
                return HttpNotFound();
            }
            return View(installation);
        }

        // POST: Installations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Installation installation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(installation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(installation);
        }

        // GET: Installations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Installation installation = db.Installations.Find(id);
            if (installation == null)
            {
                return HttpNotFound();
            }
            return View(installation);
        }

        // POST: Installations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Installation installation = db.Installations.Find(id);
            db.Installations.Remove(installation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}