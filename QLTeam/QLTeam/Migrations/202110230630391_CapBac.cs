namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CapBac : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanViens", "CapBacCode", c => c.String());
            AddColumn("dbo.TeamDetails", "CapBacCode", c => c.String());
            AddColumn("dbo.TeamDetails", "CapBacName", c => c.String());
            DropColumn("dbo.TeamDetails", "ChucVuCode");
            DropColumn("dbo.TeamDetails", "ChucVuName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeamDetails", "ChucVuName", c => c.String());
            AddColumn("dbo.TeamDetails", "ChucVuCode", c => c.String());
            DropColumn("dbo.TeamDetails", "CapBacName");
            DropColumn("dbo.TeamDetails", "CapBacCode");
            DropColumn("dbo.NhanViens", "CapBacCode");
        }
    }
}
