using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OODWebsite.Models;

namespace OODWebsite.Areas.NVPhongDaoTao.Controllers
{
    public class DanhSachKQDK_GDController : Controller
    {
        string strConString = "Data Source=DESKTOP-37M40PJ\\SQLEXPRESS;Initial Catalog=CsdlPortal;Integrated Security=True";
        // GET: NVPhongDaoTao/DanhSachKQDK_GD
        public ActionResult DanhSachKQDK_GD()
        {
            using (var cn = new SqlConnection(strConString))
            {
                String sql = "SELECT  HP.MaHP,HP.TenHP, LHP.TenLop, LHP.LT_TH, LHP.SiSo, COUNT(DK.MaLHP) AS N'Đã đăng ký' FROM MOLOP AS M INNER JOIN LOPHOCPHAN AS LHP ON M.MaLHP = LHP.MaLHP INNER JOIN HOCPHAN AS HP ON M.MSHP = HP.MSHP LEFT JOIN DANGKY AS DK ON M.MaLHP = DK.MaLHP GROUP BY HP.MaHP,HP.TenHP,HP.SoTinChi,LHP.TenLop,LHP.SiSo,LHP.LT_TH";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                List<DSLHP> model = new List<DSLHP>();
                while (rdr.Read())
                {
                    var details = new DSLHP();
                    details.MaHP = rdr["MaHP"].ToString();
                    details.TenHP = rdr["TenHP"].ToString();
                    details.TenLop = rdr["TenLop"].ToString();
                    details.SiSo = Convert.ToInt32(rdr["SiSo"].ToString());
                    details.LT_TH = rdr["LT_TH"].ToString();
                    details.ĐK = Convert.ToInt32(rdr["Đã đăng ký"].ToString());
                    model.Add(details);
                }
                return View(model);
            }
        }
    }
}