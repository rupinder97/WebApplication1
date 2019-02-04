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
    public class fine_pController : Controller
    {
        private fineContext db = new fineContext();

        // GET: fine_p
        public ActionResult Index()
        {
            return View(db.fines.ToList());
        }

        // GET: fine_p/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fine_p fine_p = db.fines.Find(id);
            if (fine_p == null)
            {
                return HttpNotFound();
            }
            return View(fine_p);
        }

        // GET: fine_p/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: fine_p/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Rollno,course,Lastdate,Fine")] fine_p fine_p)
        {
            if (ModelState.IsValid)
            {
                db.fines.Add(fine_p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fine_p);
        }

        // GET: fine_p/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fine_p fine_p = db.fines.Find(id);
            if (fine_p == null)
            {
                return HttpNotFound();
            }
            return View(fine_p);
        }

        // POST: fine_p/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Rollno,course,Lastdate,Fine")] fine_p fine_p)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fine_p).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fine_p);
        }

        // GET: fine_p/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fine_p fine_p = db.fines.Find(id);
            if (fine_p == null)
            {
                return HttpNotFound();
            }
            return View(fine_p);
        }

        // POST: fine_p/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            fine_p fine_p = db.fines.Find(id);
            db.fines.Remove(fine_p);
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
