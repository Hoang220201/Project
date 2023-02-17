using OODWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OODWebsite.Areas.QuanLyHeThong.Controllers
{
    public class XemLSDK_GDController : Controller
    {
        string strConString = "Data Source=DESKTOP-37M40PJ\\SQLEXPRESS;Initial Catalog=CsdlPortal;Integrated Security=True";
        // GET: QuanLyHeThong/XemLSDK_GD
        public ActionResult XemLSDK_GD()
        {
            using (var cn = new SqlConnection(strConString))
            {
                String sql = "SELECT  HP.MaHP, HP.TenHP, SV.MSSV, SV.HoTen, LHP.TenLop\r\nFROM SINHVIEN AS SV\r\nINNER JOIN DANGKY AS DK ON SV.Id = DK.Id\r\nINNER JOIN LOPHOCPHAN AS LHP ON DK.MaLHP = LHP.MaLHP\r\nINNER JOIN MOLOP AS MP ON LHP.MaLHP = MP.MaLHP\r\nINNER JOIN HOCPHAN AS HP ON MP.MSHP = HP.MSHP\r\nGROUP BY SV.MSSV, SV.HoTen, LHP.TenLop, HP.MaHP, HP.TenHP\r\nORDER BY HP.MaHP";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                List<LSDK> model = new List<LSDK>();
                while (rdr.Read())
                {
                    var details = new LSDK();
                    details.MSSV =rdr["MSSV"].ToString();
                    details.HoTen = rdr["HoTen"].ToString();
                    details.TenLop = rdr["TenLop"].ToString();
                    details.MaHP = rdr["MaHP"].ToString();
                    details.TenHP = rdr["TenHP"].ToString();
                    model.Add(details);
                }

                return View(model);
            }
        }
    }
}