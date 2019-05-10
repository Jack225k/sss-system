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
    public class TechniciansController : Controller
    {
        ApplicationDbContext db;
        public TechniciansController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Technicians.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technician technician = db.Technicians.Find(id);
            if (technician == null)
            {
                return HttpNotFound();
            }
            return View(technician);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Technician technician)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Technicians.Add(technician);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technician tech = db.Technicians.Find(id);
            if (tech == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            return View(tech);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(Technician technician)
        {
            if (ModelState.IsValid)
            {
                db.Entry(technician).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(technician);
        }



        // POST: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Technician technician = db.Technicians.Find(id);
                if (technician == null)
                {
                    return HttpNotFound();
                }
                db.Technicians.Remove(technician);
                db.SaveChanges();

                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }
    }
}