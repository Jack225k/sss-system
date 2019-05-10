using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SSS_System.Models;

namespace SSS_System.Controllers
{
    public class ExpertiseController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Expertisefields
        public ActionResult Index()
        {
            return View(db.Expertisefields.ToList());
        }

        // GET: Expertisefields/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpertiseField expertisefield = db.Expertisefields.Find(id);
            if (expertisefield == null)
            {
                return HttpNotFound();
            }
            return View(expertisefield);
        }

        // GET: Expertisefields/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Expertisefields/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExpertiseID,FieldExpertise")] ExpertiseField expertisefield)
        {
            if (ModelState.IsValid)
            {
                db.Expertisefields.Add(expertisefield);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(expertisefield);
        }

        // GET: Expertisefields/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpertiseField expertisefield = db.Expertisefields.Find(id);
            if (expertisefield == null)
            {
                return HttpNotFound();
            }
            return View(expertisefield);
        }

        // POST: Expertisefields/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExpertiseID,FieldExpertise")] ExpertiseField expertisefield)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expertisefield).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expertisefield);
        }

        // GET: Expertisefields/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpertiseField expertisefield = db.Expertisefields.Find(id);
            if (expertisefield == null)
            {
                return HttpNotFound();
            }
            return View(expertisefield);
        }

        // POST: Expertisefields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExpertiseField expertisefield = db.Expertisefields.Find(id);
            db.Expertisefields.Remove(expertisefield);
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
