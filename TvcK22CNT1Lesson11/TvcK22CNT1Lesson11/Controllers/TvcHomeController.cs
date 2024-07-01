using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TvcK22CNT1Lesson11.Models;

namespace TvcK22CNT1Lesson11.Controllers
{
    public class TvcHomeController : Controller
    {
        public ActionResult TvcIndex()
        {
            // lấy thông tin từ session
            //ViewBag["tvcTaiKhoan"] = "";
            if (Session["TvcMember"] != null)
            {
                ViewBag.tvcTaiKhoan = ((TvcTaiKhoan)Session["TvcMember"]).TvcFullName;
            }
            return View();
        }

        public ActionResult TvcAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TvcContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}