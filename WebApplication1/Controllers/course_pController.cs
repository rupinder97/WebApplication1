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
    public class course_pController : Controller
    {
        private courseContext db = new courseContext();

        // GET: course_p
        public ActionResult Index()
        {
            return View(db.courses.ToList());
        }

        // GET: course_p/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            course_p course_p = db.courses.Find(id);
            if (course_p == null)
            {
                return HttpNotFound();
            }
            return View(course_p);
        }

        // GET: course_p/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: course_p/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Course,Admfee,Anualfee")] course_p course_p)
        {
            if (ModelState.IsValid)
            {
                db.courses.Add(course_p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(course_p);
        }

        // GET: course_p/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            course_p course_p = db.courses.Find(id);
            if (course_p == null)
            {
                return HttpNotFound();
            }
            return View(course_p);
        }

        // POST: course_p/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Course,Admfee,Anualfee")] course_p course_p)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course_p).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course_p);
        }

        // GET: course_p/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            course_p course_p = db.courses.Find(id);
            if (course_p == null)
            {
                return HttpNotFound();
            }
            return View(course_p);
        }

        // POST: course_p/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            course_p course_p = db.courses.Find(id);
            db.courses.Remove(course_p);
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
