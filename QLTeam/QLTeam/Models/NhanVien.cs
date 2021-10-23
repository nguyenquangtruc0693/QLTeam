using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTeam.Models
{
    public class NhanVien
    {
        public int NhanVienID { get; set; }
        public int? LeaderID { get; set; }
        public int? QuanLyTrucTiepID { get; set; }
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string CapBacCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
        public virtual int TeamID { get; set; }
    }
}