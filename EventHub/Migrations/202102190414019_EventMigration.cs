namespace EventHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EventModels", newName: "Events");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Events", newName: "EventModels");
        }
    }
}
