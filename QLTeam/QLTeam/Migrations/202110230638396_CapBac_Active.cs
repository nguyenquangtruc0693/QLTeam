namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CapBac_Active : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CapBacs", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CapBacs", "Active");
        }
    }
}
