using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tqtmodel13_5.Models;

namespace tqtmodel13_5.Controllers
{
    public class TqtcusstaffController : Controller
    {
        // GET: Tqtcusstaff
        private static List<Tqtcustomer> listcustomer = new List<Tqtcustomer>()
            {
                new Tqtcustomer()
        {
            Customerid = 1,
                FirstName = "tran quang",
                LastName = "tien",
                Address = "K22cnt2",
                Yearofbirth = 2004
                },
            new Tqtcustomer()
        {
            Customerid = 2,
                FirstName = "tran quang",
                LastName = "dao",
                Address = "K22cnt2",
                Yearofbirth = 2004

            }
    };
    public ActionResult Index()
        {
            return View(listcustomer);
        }
        public ActionResult tqtcreate()
        {
            var model = new Tqtcustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult tqtcreate(Tqtcustomer model)
        {
            listcustomer.Add(model);
            return RedirectToAction("index");
        }
        public ActionResult Tqtedit (int id)
        {
            var customer = listcustomer.FirstOrDefault(x=>x.Customerid==id)
                return View(customer);
        }
    }
}