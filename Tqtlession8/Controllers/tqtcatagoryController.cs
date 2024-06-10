using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tqtlession8.Models;

namespace Tqtlession8.Controllers
{
    public class tqtcatagoryController : Controller
    {
        private static tqtBookstore _tqtBookStore;
        public tqtcatagoryController()
        {
            _tqtBookStore = new tqtBookstore();
        }
        // GET: tqtcatagory
        public ActionResult tqtIndex()
        {
            _tqtBookStore = new tqtBookstore();
            var tqtCategories = _tqtBookStore.tqtCategories.ToList();
            return View(tqtCategories);
        }
        public ActionResult Tqtcreate()
        {
            var tqtcatagory = new tqtCategory();
            return View(tqtcatagory);        }
    }
}