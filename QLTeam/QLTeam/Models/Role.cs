using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTeam.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public int NhomQuyenID { get; set; }
        public string MoTa { get; set; }
        public bool CanRead { get; set; }
        public bool CanWirte { get; set; }
        public bool CanDelete { get; set; }
        public string Screen { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}