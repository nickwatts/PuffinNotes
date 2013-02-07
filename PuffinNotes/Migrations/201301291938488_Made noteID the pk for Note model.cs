namespace PuffinNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadenoteIDthepkforNotemodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Notes", "boardID", c => c.Int(nullable: false));
            AlterColumn("dbo.Notes", "noteID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Notes", new[] { "boardID" });
            AddPrimaryKey("dbo.Notes", "noteID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Notes", new[] { "noteID" });
            AddPrimaryKey("dbo.Notes", "boardID");
            AlterColumn("dbo.Notes", "noteID", c => c.Int(nullable: false));
            AlterColumn("dbo.Notes", "boardID", c => c.Int(nullable: false, identity: true));
        }
    }
}
