using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tqtbaithigiuaky.Models;

namespace Tqtbaithigiuaky.Controllers
{
    public class TqtStudentController : Controller
    {   
        private static List<TqtStudent> tqtStudent = new List<TqtStudent>()
            {
                new     TqtStudent{TqtId=2210900129,TqtFullname="Trần Quang Tiến",TqtEmail="Yaboku209@gmail.com",TqtPhone=1234567891,TqtTuoi=20,TqtGender=1},
                new     TqtStudent{TqtId=2210900139,TqtFullname="Trần Quang Tiến",TqtEmail="Yaboku209@gmail.com",TqtPhone=1234567891,TqtTuoi=21,TqtGender=0},
            };

            // GET: TqtStudent
            public ActionResult TqtIndex()
            {
                return View(tqtStudent);
            }
        //Get :TqtCreate
        public ActionResult TqtCreate()
        {
            var tqtStudent = new TqtStudent();
            return View(tqtStudent);
        }
        public ActionResult TqtEdit()
        {
            var tqtStuDent = new TqtStudent();
            return View(tqtStuDent);
        }
    }
}