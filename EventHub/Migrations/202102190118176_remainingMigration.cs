namespace EventHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remainingMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Events", newName: "EventModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EventModels", newName: "Events");
        }
    }
}
