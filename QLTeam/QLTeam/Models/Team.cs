using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace QLTeam.Models
{
    public class Team
    {
        
        [DisplayName("Team ID")]
        public int TeamID { get; set; }
        [DisplayName("Team Code")]
        public string TeamCode { get; set; }
        [DisplayName("Tên nhóm")]
        public string TeamName { get; set; }
        [DisplayName("Mô tả")]
        public string MoTa { get; set; }
        [DisplayName("Mã công ty")]
        public int CongTyID { get; set; }
        [DisplayName("Người tạo")]
        public string CreatedBy { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime CreatedTime { get; set; }
        [DisplayName("Người cập nhật")]
        public string UpdatedBy { get; set; }
        [DisplayName("Ngày cập nhật")]
        public DateTime UpdatedTime { get; set; }

       
    }
}