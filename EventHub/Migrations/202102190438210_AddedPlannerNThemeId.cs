namespace EventHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlannerNThemeId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Events", name: "EventTheme_Id", newName: "ThemeId");
            RenameColumn(table: "dbo.Events", name: "Planner_Id", newName: "PlannerId");
            RenameIndex(table: "dbo.Events", name: "IX_Planner_Id", newName: "IX_PlannerId");
            RenameIndex(table: "dbo.Events", name: "IX_EventTheme_Id", newName: "IX_ThemeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Events", name: "IX_ThemeId", newName: "IX_EventTheme_Id");
            RenameIndex(table: "dbo.Events", name: "IX_PlannerId", newName: "IX_Planner_Id");
            RenameColumn(table: "dbo.Events", name: "PlannerId", newName: "Planner_Id");
            RenameColumn(table: "dbo.Events", name: "ThemeId", newName: "EventTheme_Id");
        }
    }
}
