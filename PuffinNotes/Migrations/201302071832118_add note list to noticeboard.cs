namespace PuffinNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnotelisttonoticeboard : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.Notes", "boardID", "dbo.NoticeBoards", "boardId", cascadeDelete: true);
            CreateIndex("dbo.Notes", "boardID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Notes", new[] { "boardID" });
            DropForeignKey("dbo.Notes", "boardID", "dbo.NoticeBoards");
        }
    }
}
