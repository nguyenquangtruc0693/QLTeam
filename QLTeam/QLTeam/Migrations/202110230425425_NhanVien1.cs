namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NhanVien1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanViens", "TeamID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanViens", "TeamID");
        }
    }
}
