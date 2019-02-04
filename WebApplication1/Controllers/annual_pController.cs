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
    public class annual_pController : Controller
    {
        private annualContext db = new annualContext();

        // GET: annual_p
        public ActionResult Index()
        {
            return View(db.annuals.ToList());
        }

        // GET: annual_p/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            annual_p annual_p = db.annuals.Find(id);
            if (annual_p == null)
            {
                return HttpNotFound();
            }
            return View(annual_p);
        }

        // GET: annual_p/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: annual_p/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Rollno,Feetype,Fees,Latefee,Feerec,Dor")] annual_p annual_p)
        {
            if (ModelState.IsValid)
            {
                db.annuals.Add(annual_p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(annual_p);
        }

        // GET: annual_p/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            annual_p annual_p = db.annuals.Find(id);
            if (annual_p == null)
            {
                return HttpNotFound();
            }
            return View(annual_p);
        }

        // POST: annual_p/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Rollno,Feetype,Fees,Latefee,Feerec,Dor")] annual_p annual_p)
        {
            if (ModelState.IsValid)
            {
                db.Entry(annual_p).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(annual_p);
        }

        // GET: annual_p/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            annual_p annual_p = db.annuals.Find(id);
            if (annual_p == null)
            {
                return HttpNotFound();
            }
            return View(annual_p);
        }

        // POST: annual_p/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            annual_p annual_p = db.annuals.Find(id);
            db.annuals.Remove(annual_p);
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
