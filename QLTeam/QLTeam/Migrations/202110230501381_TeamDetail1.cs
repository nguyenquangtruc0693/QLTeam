namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamDetail1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TeamDetails", "NhanVienID", "dbo.NhanViens");
            DropForeignKey("dbo.TeamDetails", "TeamID", "dbo.Teams");
            DropIndex("dbo.TeamDetails", new[] { "TeamID" });
            DropIndex("dbo.TeamDetails", new[] { "NhanVienID" });
            AddColumn("dbo.TeamDetails", "MaNhanVien", c => c.String());
            AddColumn("dbo.TeamDetails", "HoTen", c => c.String());
            AddColumn("dbo.TeamDetails", "TeamCode", c => c.String());
            AddColumn("dbo.TeamDetails", "TeamName", c => c.String());
            AddColumn("dbo.TeamDetails", "MoTa", c => c.String());
            AddColumn("dbo.TeamDetails", "CongTyID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamDetails", "CongTyID");
            DropColumn("dbo.TeamDetails", "MoTa");
            DropColumn("dbo.TeamDetails", "TeamName");
            DropColumn("dbo.TeamDetails", "TeamCode");
            DropColumn("dbo.TeamDetails", "HoTen");
            DropColumn("dbo.TeamDetails", "MaNhanVien");
            CreateIndex("dbo.TeamDetails", "NhanVienID");
            CreateIndex("dbo.TeamDetails", "TeamID");
            AddForeignKey("dbo.TeamDetails", "TeamID", "dbo.Teams", "TeamID", cascadeDelete: true);
            AddForeignKey("dbo.TeamDetails", "NhanVienID", "dbo.NhanViens", "NhanVienID", cascadeDelete: true);
        }
    }
}
