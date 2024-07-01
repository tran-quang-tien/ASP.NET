using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TqtSinhvien.Models;

namespace TqtSinhvien.Controllers
{
    public class TqtSinhviensController : Controller
    {
        private TqtQuanlysvEntities db = new TqtQuanlysvEntities();

        // GET: TqtSinhviens
        public ActionResult Index()
        {
            var tqtSinhviens = db.TqtSinhviens.Include(t => t.TqtKhoa);
            return View(tqtSinhviens.ToList());
        }

        // GET: TqtSinhviens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TqtSinhvien tqtSinhvien = db.TqtSinhviens.Find(id);
            if (tqtSinhvien == null)
            {
                return HttpNotFound();
            }
            return View(tqtSinhvien);
        }

        // GET: TqtSinhviens/Create
        public ActionResult Create()
        {
            ViewBag.MaKh = new SelectList(db.TqtKhoas, "MaKH", "TenKH");
            return View();
        }

        // POST: TqtSinhviens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSV,HoSV,TenSV,Phai,Ngaysinh,Noisinh,MaKh,Hocbong,Diemtrungbinh")] TqtSinhvien tqtSinhvien)
        {
            if (ModelState.IsValid)
            {
                db.TqtSinhviens.Add(tqtSinhvien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKh = new SelectList(db.TqtKhoas, "MaKH", "TenKH", tqtSinhvien.MaKh);
            return View(tqtSinhvien);
        }

        // GET: TqtSinhviens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TqtSinhvien tqtSinhvien = db.TqtSinhviens.Find(id);
            if (tqtSinhvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKh = new SelectList(db.TqtKhoas, "MaKH", "TenKH", tqtSinhvien.MaKh);
            return View(tqtSinhvien);
        }

        // POST: TqtSinhviens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSV,HoSV,TenSV,Phai,Ngaysinh,Noisinh,MaKh,Hocbong,Diemtrungbinh")] TqtSinhvien tqtSinhvien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tqtSinhvien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKh = new SelectList(db.TqtKhoas, "MaKH", "TenKH", tqtSinhvien.MaKh);
            return View(tqtSinhvien);
        }

        // GET: TqtSinhviens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TqtSinhvien tqtSinhvien = db.TqtSinhviens.Find(id);
            if (tqtSinhvien == null)
            {
                return HttpNotFound();
            }
            return View(tqtSinhvien);
        }

        // POST: TqtSinhviens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TqtSinhvien tqtSinhvien = db.TqtSinhviens.Find(id);
            db.TqtSinhviens.Remove(tqtSinhvien);
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
