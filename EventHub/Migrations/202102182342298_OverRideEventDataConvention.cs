namespace EventHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverRideEventDataConvention : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Planner_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "Planner_Id" });
            AlterColumn("dbo.Events", "Place", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Events", "Planner_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Themes", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Events", "Planner_Id");
            AddForeignKey("dbo.Events", "Planner_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Planner_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "Planner_Id" });
            AlterColumn("dbo.Themes", "Name", c => c.String());
            AlterColumn("dbo.Events", "Planner_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Events", "Place", c => c.String());
            CreateIndex("dbo.Events", "Planner_Id");
            AddForeignKey("dbo.Events", "Planner_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
