namespace EventHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventThemeRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "EventTheme_Id", "dbo.Themes");
            DropIndex("dbo.Events", new[] { "EventTheme_Id" });
            AlterColumn("dbo.Events", "EventTheme_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "EventTheme_Id");
            AddForeignKey("dbo.Events", "EventTheme_Id", "dbo.Themes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EventTheme_Id", "dbo.Themes");
            DropIndex("dbo.Events", new[] { "EventTheme_Id" });
            AlterColumn("dbo.Events", "EventTheme_Id", c => c.Int());
            CreateIndex("dbo.Events", "EventTheme_Id");
            AddForeignKey("dbo.Events", "EventTheme_Id", "dbo.Themes", "Id");
        }
    }
}
