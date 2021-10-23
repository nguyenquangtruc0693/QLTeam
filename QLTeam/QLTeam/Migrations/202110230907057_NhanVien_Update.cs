namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NhanVien_Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanViens", "LeaderID", c => c.Int(nullable: false));
            AddColumn("dbo.NhanViens", "QuanLyTrucTiepID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanViens", "QuanLyTrucTiepID");
            DropColumn("dbo.NhanViens", "LeaderID");
        }
    }
}
