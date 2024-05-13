using lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab4.Controllers
{
    public class tqtcustomerController : Controller
    {
        // GET: tqtcustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Custommerdetail()
        {
            Tqtcustomers cus = new Tqtcustomers()
            {
                CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "Hà Nội",
                Email = "devmaster.founder@gmail.com",
                Phone = "0978.611.889",
                Balance = 15200000
              
            };
            return View(cus);
        }
        public ActionResult CustomerList()
        {
            List<Tqtcustomers> listcustomer = new List<Tqtcustomers>(){
new Tqtcustomers(){ CustomerId = "KH001",
FullName = "Trịnh Văn Chung",
Address = "Hà Nội",Email = "devmaster.founder@gmail.com",
Phone = "0978.611.889",Balance = 15200000},
new Tqtcustomers(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc",
Address = "Hà Nội",Email = "cucdt@gmail.com",
Phone = "0986.767.444",Balance = 2200000},
new Tqtcustomers(){ CustomerId = "KH003",
FullName = "Nguyễn Tuấn Thắng",
Address = "Nam Định",Email = "thangnt@gmail.com",
Phone = "0924.656.542",Balance = 1200000},
new Tqtcustomers(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải",
Address = "Hà Nội",Email = "hailn@gmail.com",
Phone = "0996.555.267",Balance = 6200000 }
};
           
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}