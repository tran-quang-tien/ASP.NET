using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tqtmodel13_5.Models;

namespace tqtmodel13_5.Controllers
{
    public class TqtcustomerController : Controller
    {
        // GET: Tqtcustomer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tqtcusdetail()
        {
            var tqtcustomer = new Tqtcustomer
            {
                Customerid = 1,
                FirstName = "tran quang",
                LastName = "tien",
                Address = "K22cnt2",
                Yearofbirth = 2004
            };

            ViewBag.customer = tqtcustomer;
            return View();
        }
        public ActionResult Tqtlistcus()
        {
            var list = new List<Tqtcustomer>()
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
            ViewBag.list = list;
            return View();
        }
    }
    
}