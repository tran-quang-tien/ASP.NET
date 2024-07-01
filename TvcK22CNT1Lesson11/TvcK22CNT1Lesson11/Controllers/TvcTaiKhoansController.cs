using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TvcK22CNT1Lesson11.Models;
using TvcK22CNT1Lesson11.ModelViews;

namespace TvcK22CNT1Lesson11.Controllers
{
    public class TvcTaiKhoansController : Controller
    {
        private TvcLesson11DbsEntities db = new TvcLesson11DbsEntities();

        // GET: TvcTaiKhoans
        public ActionResult Index()
        {
            return View(db.TvcTaiKhoan.ToList());
        }

        // GET: TvcTaiKhoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvcTaiKhoan tvcTaiKhoan = db.TvcTaiKhoan.Find(id);
            if (tvcTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(tvcTaiKhoan);
        }

        // GET: TvcTaiKhoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TvcTaiKhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TvcId,TvcUserName,TvcPassword,TvcFullName,TvcAge,TvcEmail,TvcPhone,TvcStatus")] TvcTaiKhoan tvcTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.TvcTaiKhoan.Add(tvcTaiKhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tvcTaiKhoan);
        }

        // GET: TvcTaiKhoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvcTaiKhoan tvcTaiKhoan = db.TvcTaiKhoan.Find(id);
            if (tvcTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(tvcTaiKhoan);
        }

        // POST: TvcTaiKhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TvcId,TvcUserName,TvcPassword,TvcFullName,TvcAge,TvcEmail,TvcPhone,TvcStatus")] TvcTaiKhoan tvcTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tvcTaiKhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tvcTaiKhoan);
        }

        // GET: TvcTaiKhoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvcTaiKhoan tvcTaiKhoan = db.TvcTaiKhoan.Find(id);
            if (tvcTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(tvcTaiKhoan);
        }

        // POST: TvcTaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TvcTaiKhoan tvcTaiKhoan = db.TvcTaiKhoan.Find(id);
            db.TvcTaiKhoan.Remove(tvcTaiKhoan);
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

        // Form đăng nhập hệ thống
        public ActionResult TvcLogin()
        {
            var tvcModel = new TvcLoginModel();
            return View(tvcModel);
        }

        [HttpPost]
        public ActionResult TvcLogin(TvcLoginModel tvcModel)
        {
            // khi người dùng nhấn nút đăng nhập; xử lý và tìm kiến, so sanh trong db

            var tvcCheckLogin = db.TvcTaiKhoan.Where(x => x.TvcUserName.Equals(tvcModel.TvcUserName) && x.TvcPassword.Equals(tvcModel.TvcPassword)).FirstOrDefault();
            if(tvcCheckLogin != null)
            {
                //Lưu trữ session
                Session["TvcMember"] = tvcCheckLogin;

                return Redirect("/");
            }
            return View(tvcModel);
        }
        public ActionResult Logout()
        {
            Session.Remove("TvcMember");
            return Redirect("/");
        }
    }
}
