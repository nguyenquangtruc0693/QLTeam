namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NhanVien_Update1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NhanViens", "LeaderID", c => c.Int());
            AlterColumn("dbo.NhanViens", "QuanLyTrucTiepID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhanViens", "QuanLyTrucTiepID", c => c.Int(nullable: false));
            AlterColumn("dbo.NhanViens", "LeaderID", c => c.Int(nullable: false));
        }
    }
}
