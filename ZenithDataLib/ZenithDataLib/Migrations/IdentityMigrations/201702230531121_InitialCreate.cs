namespace ZenithDataLib.Migrations.IdentityMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Event_EventId", "dbo.Events");
            DropIndex("dbo.Events", new[] { "Event_EventId" });
            DropColumn("dbo.Events", "Event_EventId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Event_EventId", c => c.Int());
            CreateIndex("dbo.Events", "Event_EventId");
            AddForeignKey("dbo.Events", "Event_EventId", "dbo.Events", "EventId");
        }
    }
}
