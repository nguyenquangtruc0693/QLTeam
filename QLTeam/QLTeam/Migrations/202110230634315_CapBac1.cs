namespace QLTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CapBac1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CapBacs",
                c => new
                    {
                        CapBacID = c.Int(nullable: false, identity: true),
                        CapBacCode = c.String(),
                        CapBacName = c.String(),
                        MoTa = c.String(),
                        CreatedBy = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CapBacID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CapBacs");
        }
    }
}
