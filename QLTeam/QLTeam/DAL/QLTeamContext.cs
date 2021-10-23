using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLTeam.Models;
using System.Data.Entity;
namespace QLTeam.DAL
{
    public class QLTeamContext : DbContext
    {
        public QLTeamContext() : base("QLTeamContext")
        {

        }

        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamDetail> TeamDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<LichSuCongTac> LichSuCongTacs { get; set; }
        public DbSet<CapBac> CapBacs { get; set; }

    }
}