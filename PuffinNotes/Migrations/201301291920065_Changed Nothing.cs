namespace PuffinNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNothing : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        boardID = c.Int(nullable: false, identity: true),
                        noteID = c.Int(nullable: false),
                        content = c.String(),
                        placementCoordinates = c.Int(nullable: false),
                        author = c.String(),
                    })
                .PrimaryKey(t => t.boardID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notes");
        }
    }
}
