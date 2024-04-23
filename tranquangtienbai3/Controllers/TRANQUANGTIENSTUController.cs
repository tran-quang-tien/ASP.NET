using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tranquangtienbai3.Controllers
{
    public class TRANQUANGTIENSTUController : Controller
    {
        // GET: TRANQUANGTIENSTU
        public ActionResult Index()
        {
            ViewData["msg"] = "View Data - Tran Quang TIen";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/MM/yyy tt");
            return View();
        }
        public  ActionResult Studentlist()
        {
            ViewBag.tittlename = "danh sach hoc vien - tran quang tien";
            string[] names = { "tran tien", "ta hong", "vuong dinh" };
            ViewBag.list = names;
          var obj = new
                {
            ID = 100,
            name = "tran tien",
            age=20,
        };
            ViewBag.student = obj;

            return View();
        }
        public ActionResult insert()
        {
            return View("addstudent");
        }
    }
}