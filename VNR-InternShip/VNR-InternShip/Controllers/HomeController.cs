using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VNR_InternShip.Controllers
{
    public class HomeController : Controller
    {
        private VNR_DBDataContext context = new VNR_DBDataContext();

        public ActionResult Index()
        {
            var Courses = context.KhoaHocs.ToList();
            return View(Courses);
        }

        public ActionResult Subject(int id)
        {
            var Subject = context.MonHocs.ToList().FindAll(m => m.KhoaHocID == id);
            ViewBag.CourseName = context.KhoaHocs.ToList().Find(m => m.ID == id);
            return View(Subject);
        }

    }
}