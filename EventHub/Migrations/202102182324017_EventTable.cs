namespace EventHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Place = c.String(),
                        EventTheme_Id = c.Int(),
                        Planner_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Themes", t => t.EventTheme_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Planner_Id)
                .Index(t => t.EventTheme_Id)
                .Index(t => t.Planner_Id);
            
            CreateTable(
                "dbo.Themes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Planner_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Events", "EventTheme_Id", "dbo.Themes");
            DropIndex("dbo.Events", new[] { "Planner_Id" });
            DropIndex("dbo.Events", new[] { "EventTheme_Id" });
            DropTable("dbo.Themes");
            DropTable("dbo.Events");
        }
    }
}
