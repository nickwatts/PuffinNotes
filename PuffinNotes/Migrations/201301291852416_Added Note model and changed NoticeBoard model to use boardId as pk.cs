namespace PuffinNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNotemodelandchangedNoticeBoardmodeltouseboardIdaspk : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.NoticeBoards", new[] { "iD" });
            DropColumn("dbo.NoticeBoards", "iD");
            AddColumn("dbo.NoticeBoards", "boardId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.NoticeBoards", "boardId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NoticeBoards", "iD", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.NoticeBoards", new[] { "boardId" });
            AddPrimaryKey("dbo.NoticeBoards", "iD");
            DropColumn("dbo.NoticeBoards", "boardId");
        }
    }
}
