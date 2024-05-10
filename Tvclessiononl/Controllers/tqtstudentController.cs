using System.Web.Mvc;

namespace Tvclessiononl.Controllers
{
    public class tqtstudentController : Controller
    {
        // GET: tqtstudent
        /// <summary>
        /// ten: tran quang tien
        /// lop: k22cntt2
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.fullname = "tran tien";
            ViewData["birthday"] = "20/09/2004";
            TempData["sdt"] = "0969458664";
            return View();
        }
        public ActionResult details()
        {
            string tq = "";
            tq += "<h3> họ và tên : trần quang tiến<h3/>";
            tq += "<h3> mã sinh viên:2210900129<h3/>";
            tq += "<h3>địa chỉ: Hà Nôik<h3/>";
            ViewBag.details = tq;
            return View("chitiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "tran quang tien ", "nguyen thi tien" };
            ViewBag.name = names;   
            return View();
        }
        public ActionResult addstu()
        {
            return View();
        }
        public ActionResult addsu(FormCollection form)
        {
            string fullname = form["fullname"];
            string masinhvien = form["ma sinh vien"];
            string taikhoan = form["taikhoan"];
            string matkhau = form["matkhau"];

            string tq = "<h3>" + fullname + "</h3>";
            tq += "<p>" + masinhvien;
            tq += "<p>" + taikhoan;
            tq += "<p>" + matkhau;
            ViewBag.info = tq;
            return View("ketqua");
        }
    }
}