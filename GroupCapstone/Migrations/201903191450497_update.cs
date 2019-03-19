namespace GroupCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "User", c => c.String());
            AddColumn("dbo.Comments", "EventId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "EventId");
            AddForeignKey("dbo.Comments", "EventId", "dbo.Events", "EventId", cascadeDelete: true);
            DropColumn("dbo.Events", "CommentId");
            DropColumn("dbo.Comments", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "CommentId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Comments", "EventId", "dbo.Events");
            DropIndex("dbo.Comments", new[] { "EventId" });
            DropColumn("dbo.Comments", "EventId");
            DropColumn("dbo.Comments", "User");
        }
    }
}