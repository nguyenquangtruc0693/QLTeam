namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.TeamDetails", "NhanVienID");
            AddForeignKey("dbo.TeamDetails", "NhanVienID", "dbo.NhanViens", "NhanVienID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamDetails", "NhanVienID", "dbo.NhanViens");
            DropIndex("dbo.TeamDetails", new[] { "NhanVienID" });
        }
    }
}
