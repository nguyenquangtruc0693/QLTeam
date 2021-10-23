namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamDetail : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TeamDetails", "TeamID", c => c.Int(nullable: false));
            AlterColumn("dbo.TeamDetails", "ChucVuName", c => c.String());
            CreateIndex("dbo.TeamDetails", "TeamID");
            AddForeignKey("dbo.TeamDetails", "TeamID", "dbo.Teams", "TeamID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamDetails", "TeamID", "dbo.Teams");
            DropIndex("dbo.TeamDetails", new[] { "TeamID" });
            AlterColumn("dbo.TeamDetails", "ChucVuName", c => c.Int(nullable: false));
            AlterColumn("dbo.TeamDetails", "TeamID", c => c.String());
        }
    }
}
