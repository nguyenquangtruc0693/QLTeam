using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTeam.Models
{
    public class CapBac
    {
        public int CapBacID { get; set; }
        public string CapBacCode { get; set; }
        public string CapBacName { get; set; }
        public string MoTa { get; set; }
        public string CreatedBy { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}