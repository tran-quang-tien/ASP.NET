using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lesson11.Models;
using lesson11.ModelsView;

namespace lesson11.Controllers
{
    public class TqtTaikhoansController : Controller
    {
        private TqtLession11Entities db = new TqtLession11Entities();

        // GET: TqtTaikhoans
        public ActionResult Index()
        {
            return View(db.TqtTaikhoans.ToList());
        }

        // GET: TqtTaikhoans/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TqtTaikhoan tqtTaikhoan = db.TqtTaikhoans.Find(id);
            if (tqtTaikhoan == null)
            {
                return HttpNotFound();
            }
            return View(tqtTaikhoan);
        }

        // GET: TqtTaikhoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TqtTaikhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TqtId,TqtUser,TqtPass,TqtName,TqtAge,TqtEmail,TqtPhone,TqtStatus")] TqtTaikhoan tqtTaikhoan)
        {
            if (ModelState.IsValid)
            {
                db.TqtTaikhoans.Add(tqtTaikhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tqtTaikhoan);
        }

        // GET: TqtTaikhoans/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TqtTaikhoan tqtTaikhoan = db.TqtTaikhoans.Find(id);
            if (tqtTaikhoan == null)
            {
                return HttpNotFound();
            }
            return View(tqtTaikhoan);
        }

        // POST: TqtTaikhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TqtId,TqtUser,TqtPass,TqtName,TqtAge,TqtEmail,TqtPhone,TqtStatus")] TqtTaikhoan tqtTaikhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tqtTaikhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tqtTaikhoan);
        }

        // GET: TqtTaikhoans/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TqtTaikhoan tqtTaikhoan = db.TqtTaikhoans.Find(id);
            if (tqtTaikhoan == null)
            {
                return HttpNotFound();
            }
            return View(tqtTaikhoan);
        }

        // POST: TqtTaikhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TqtTaikhoan tqtTaikhoan = db.TqtTaikhoans.Find(id);
            db.TqtTaikhoans.Remove(tqtTaikhoan);
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
        public ActionResult TvcLogin()
        {
            var tqtModel = new Class1();
            return View(tqtModel);
        }

        [HttpPost]
        public ActionResult TvcLogin(Class1 tqtModel)
        {
            // khi người dùng nhấn nút đăng nhập; xử lý và tìm kiến, so sanh trong db

            var tqtCheckLogin = db.TqtTaikhoans.Where(x => x.TqtUser.Equals(tqtModel.TqtUser) && x.TqtPass.Equals(tqtModel.TqtPass)).FirstOrDefault();
            if (tqtCheckLogin != null)
            {
                //Lưu trữ session
                Session["TqtMember"] = tqtCheckLogin;

                return Redirect("/");
            }
            return View(tqtModel);
        }
        public ActionResult Logout()
        {
            Session.Remove("TqtMember");
            return Redirect("/");
        }
    }
}
