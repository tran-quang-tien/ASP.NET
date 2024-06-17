using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TqtLession7.Models;

namespace TqtLession7.Controllers
{
    public class TqtkhoasController : Controller
    {
        private Tqtlesson07Entities db = new Tqtlesson07Entities();

        // GET: Tqtkhoas
        public ActionResult Index()
        {
            return View(db.Tqtkhoas.ToList());
        }

        // GET: Tqtkhoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tqtkhoa tqtkhoa = db.Tqtkhoas.Find(id);
            if (tqtkhoa == null)
            {
                return HttpNotFound();
            }
            return View(tqtkhoa);
        }

        // GET: Tqtkhoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tqtkhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TqtMakh,TqtTenkh,TqtTrangthai")] Tqtkhoa tqtkhoa)
        {
            if (ModelState.IsValid)
            {
                db.Tqtkhoas.Add(tqtkhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tqtkhoa);
        }

        // GET: Tqtkhoas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tqtkhoa tqtkhoa = db.Tqtkhoas.Find(id);
            if (tqtkhoa == null)
            {
                return HttpNotFound();
            }
            return View(tqtkhoa);
        }

        // POST: Tqtkhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TqtMakh,TqtTenkh,TqtTrangthai")] Tqtkhoa tqtkhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tqtkhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tqtkhoa);
        }

        // GET: Tqtkhoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tqtkhoa tqtkhoa = db.Tqtkhoas.Find(id);
            if (tqtkhoa == null)
            {
                return HttpNotFound();
            }
            return View(tqtkhoa);
        }

        // POST: Tqtkhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tqtkhoa tqtkhoa = db.Tqtkhoas.Find(id);
            db.Tqtkhoas.Remove(tqtkhoa);
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
