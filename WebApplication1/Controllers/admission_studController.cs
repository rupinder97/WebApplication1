using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Business;

namespace WebApplication1.Controllers
{
    public class admission_studController : Controller
    {
        private admissionContext db = new admissionContext();

        // GET: admission_stud
        public ActionResult Index()
        {
            return View(db.admissions.ToList());
        }

        // GET: admission_stud/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            admission_stud admission_stud = db.admissions.Find(id);
            if (admission_stud == null)
            {
                return HttpNotFound();
            }
            return View(admission_stud);
        }

        // GET: admission_stud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admission_stud/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Rollno,Name,Father,Dod,Contactno,Session_year,Course,Fee_rec,Doa")] admission_stud admission_stud)
        {
            if (ModelState.IsValid)
            {
                db.admissions.Add(admission_stud);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admission_stud);
        }

        // GET: admission_stud/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            admission_stud admission_stud = db.admissions.Find(id);
            if (admission_stud == null)
            {
                return HttpNotFound();
            }
            return View(admission_stud);
        }

        // POST: admission_stud/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Rollno,Name,Father,Dod,Contactno,Session_year,Course,Fee_rec,Doa")] admission_stud admission_stud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admission_stud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admission_stud);
        }

        // GET: admission_stud/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            admission_stud admission_stud = db.admissions.Find(id);
            if (admission_stud == null)
            {
                return HttpNotFound();
            }
            return View(admission_stud);
        }

        // POST: admission_stud/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            admission_stud admission_stud = db.admissions.Find(id);
            db.admissions.Remove(admission_stud);
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
