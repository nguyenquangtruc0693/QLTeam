namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LichSuCongTacs",
                c => new
                    {
                        LichSuCongTacID = c.Int(nullable: false, identity: true),
                        NhanVienID = c.Int(nullable: false),
                        TeamID = c.Int(nullable: false),
                        ChucVuCode = c.String(),
                        CongTyID = c.Int(nullable: false),
                        ThoiGianBatDau = c.DateTime(nullable: false),
                        ThoiGianketThuc = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LichSuCongTacID);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        NhanVienID = c.Int(nullable: false, identity: true),
                        MaNhanVien = c.String(),
                        HoTen = c.String(),
                        CreatedBy = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NhanVienID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        NhomQuyenID = c.Int(nullable: false),
                        MoTa = c.String(),
                        CanRead = c.Boolean(nullable: false),
                        CanWirte = c.Boolean(nullable: false),
                        CanDelete = c.Boolean(nullable: false),
                        Screen = c.String(),
                        CreatedBy = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.TeamDetails",
                c => new
                    {
                        TeamDetailID = c.Int(nullable: false, identity: true),
                        TeamID = c.String(),
                        NhomQuyenID = c.Int(nullable: false),
                        ChucVuCode = c.String(),
                        ChucVuName = c.Int(nullable: false),
                        NhanVienID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TeamDetailID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: true),
                        TeamCode = c.String(),
                        TeamName = c.String(),
                        MoTa = c.String(),
                        CongTyID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TeamID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
            DropTable("dbo.TeamDetails");
            DropTable("dbo.Roles");
            DropTable("dbo.NhanViens");
            DropTable("dbo.LichSuCongTacs");
        }
    }
}
