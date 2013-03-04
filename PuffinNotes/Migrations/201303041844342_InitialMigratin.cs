namespace PuffinNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigratin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NoticeBoards",
                c => new
                    {
                        boardId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        owner = c.String(),
                    })
                .PrimaryKey(t => t.boardId);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        noteID = c.Int(nullable: false, identity: true),
                        boardID = c.Int(nullable: false),
                        content = c.String(),
                        xCoordinate = c.Int(nullable: false),
                        yCoordinate = c.Int(nullable: false),
                        zCoordinate = c.Int(nullable: false),
                        author = c.String(),
                    })
                .PrimaryKey(t => t.noteID)
                .ForeignKey("dbo.NoticeBoards", t => t.boardID, cascadeDelete: true)
                .Index(t => t.boardID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Notes", new[] { "boardID" });
            DropForeignKey("dbo.Notes", "boardID", "dbo.NoticeBoards");
            DropTable("dbo.Notes");
            DropTable("dbo.NoticeBoards");
        }
    }
}
