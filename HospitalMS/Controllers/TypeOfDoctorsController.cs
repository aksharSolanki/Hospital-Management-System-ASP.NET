using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HospitalMS.Models;

namespace HospitalMS.Controllers
{
    public class TypeOfDoctorsController : AuthController
    {
        private ContextClass db = new ContextClass();

        // GET: TypeOfDoctors
        public ActionResult Index()
        {
            return View(db.TypeOfDoctors.ToList());
        }

        [HttpPost]
        public ActionResult Index(string search)
        {
            return View(db.TypeOfDoctors.Where(x => search == null || x.Name.Contains(search) || x.Description.Contains(search)).ToList());
        }

        // GET: TypeOfDoctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeOfDoctor typeOfDoctor = db.TypeOfDoctors.Find(id);
            if (typeOfDoctor == null)
            {
                return HttpNotFound();
            }
            return View(typeOfDoctor);
        }

        // GET: TypeOfDoctors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeOfDoctors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] TypeOfDoctor typeOfDoctor)
        {
            if (ModelState.IsValid)
            {
                db.TypeOfDoctors.Add(typeOfDoctor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeOfDoctor);
        }

        // GET: TypeOfDoctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeOfDoctor typeOfDoctor = db.TypeOfDoctors.Find(id);
            if (typeOfDoctor == null)
            {
                return HttpNotFound();
            }
            return View(typeOfDoctor);
        }

        // POST: TypeOfDoctors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] TypeOfDoctor typeOfDoctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeOfDoctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeOfDoctor);
        }

        // GET: TypeOfDoctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeOfDoctor typeOfDoctor = db.TypeOfDoctors.Find(id);
            if (typeOfDoctor == null)
            {
                return HttpNotFound();
            }
            return View(typeOfDoctor);
        }

        // POST: TypeOfDoctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeOfDoctor typeOfDoctor = db.TypeOfDoctors.Find(id);
            db.TypeOfDoctors.Remove(typeOfDoctor);
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
