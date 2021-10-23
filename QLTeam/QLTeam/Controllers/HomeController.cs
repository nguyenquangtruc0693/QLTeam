using QLTeam.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTeam.Models;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace QLTeam.Controllers
{
    public class HomeController : Controller
    {
        private QLTeamContext db = new QLTeamContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Tìm kiếm";
            ViewBag.CapBac = db.CapBacs.ToList();
            return View();
        }
        [HttpPost]
        public string StoreSearch(string HoTen, string MaNhanVien, string CapBacCode, string CreatedTime)
        {
            string rs = string.Empty;
            rs += "<tr><th>Team ID</th>";
            rs += "<th>Mã nhân viên</th>";
            rs += "<th>Họ tên</th>";
            rs += "<th>Cấp bậc</th>";
            rs += "<th>Người tạo</th>";
            rs += "<th>Ngày tạo</th>";
            rs += "<th>Người cập nhật</th>";
            rs += "<th>Ngày cập nhật</th></tr>";
            List<NhanVien> result = new List<NhanVien>();
            var clientIdParameter1 = new SqlParameter("@HoTen", HoTen);
            var clientIdParameter2 = new SqlParameter("@MaNhanVien", MaNhanVien);
            var clientIdParameter3 = new SqlParameter("@CapBacCode", CapBacCode);
            var clientIdParameter4 = new SqlParameter("@CreatedTime", CreatedTime);
            result = db.Database
                    .SqlQuery<NhanVien>("SearchNhanVien @HoTen,@MaNhanVien,@CapBacCode,@CreatedTime", clientIdParameter1, clientIdParameter2, clientIdParameter3, clientIdParameter4)
                    .ToList();
            foreach(var nv in result)
            {
                rs += "<tr><td>" + nv.TeamID + "</td>";
                rs += "<td>" + nv.NhanVienID + "</td>";
                rs += "<td>" + nv.HoTen + "</td>";
                rs += "<td>" + nv.CapBacCode + "</td>";
                rs += "<td>" + nv.CreatedBy + "</td>";
                rs += "<td>" + nv.CreatedTime.ToString("dd/MM/yyyy") + "</td>";
                rs += "<td>" + nv.UpdatedBy + "</td>";
                rs += "<td>" + nv.UpdatedTime.ToString("dd/MM/yyyy") + "</td></tr>";
            }
            var json = new JavaScriptSerializer().Serialize(rs);
            return json.ToString();
        }
    }
}