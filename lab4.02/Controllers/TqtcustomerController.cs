using lab4_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab4_02.Controllers
{
    public class TqtcustomerController : Controller
    {
        static CustomerRepository listCustomer;

        public TqtcustomerController()
        {
            listCustomer = new CustomerRepository();
        }

        // GET: /Tqtcustomer
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Tqtcustomer/GetCustomers
        public ActionResult GetCustomers()
        {
            return View(listCustomer.GetCustomers());
        }

        // POST: /Tqtcustomer/GetCustomers
        [HttpPost]
        public ActionResult GetCustomers(string name)
        {
            return View(listCustomer.SearchCustomer(name));
        }

        // GET: /Tqtcustomer/Details/5
        public ActionResult Details(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }

        // GET: /Tqtcustomer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Tqtcustomer/Create
        [HttpPost]
        public ActionResult Create(tqtcustomer cus)
        {
            listCustomer.AddCustomer(cus);
            return RedirectToAction("GetCustomers");
        }

        // GET: /Tqtcustomer/Edit/5
        public ActionResult Edit(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }

        // POST: /Tqtcustomer/Edit
        [HttpPost]
        public ActionResult Edit(tqtcustomer cus)
        {
            listCustomer.UpdateCustomer(cus);
            return RedirectToAction("GetCustomers");
        }

        // GET: /Tqtcustomer/Delete/5
        public ActionResult Delete(string id)
        {
            listCustomer.DeleteCustomer(listCustomer.GetCustomer(id));
            return RedirectToAction("GetCustomers");
        }
    }
}