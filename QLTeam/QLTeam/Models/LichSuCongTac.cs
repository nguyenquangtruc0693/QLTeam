using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTeam.Models
{
    public class LichSuCongTac
    {
        public int LichSuCongTacID { get; set; }
        public int NhanVienID { get; set; }
        public int TeamID { get; set; }
        public string ChucVuCode { get; set; }
        public int CongTyID { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianketThuc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}