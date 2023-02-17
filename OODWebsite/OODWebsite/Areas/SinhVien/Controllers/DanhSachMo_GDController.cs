using OODWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace OODWebsite.Areas.SinhVien.Controllers
{
    public class DanhSachMo_GDController : Controller
    {
        PortalDBDataContext db = new PortalDBDataContext();
        List<DSLHP> model = new List<DSLHP>();
        // GET: SinhVien/DanhSachMo_GD

        public ActionResult DanhachMo()
        {
            ViewBag.Nam = new SelectList(db.MOLOPs, "Nam","Nam");
            ViewBag.HK = new SelectList(db.MOLOPs, "HocKy","HocKy");
            return View();
        }
    
    
     }
 }
