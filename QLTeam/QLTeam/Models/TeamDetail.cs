using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTeam.Models
{
    public class TeamDetail
    {
        public int TeamDetailID { get; set; }
        public int TeamID { get; set; }
        public int NhomQuyenID { get; set; }
        public string CapBacCode { get; set; }
        public string CapBacName { get; set; }
        public int NhanVienID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public string MoTa { get; set; }
        public int CongTyID { get; set; }

    }
}