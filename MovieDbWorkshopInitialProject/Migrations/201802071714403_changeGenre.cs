namespace MovieDbWorkshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenre : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Title", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
        }
    }
}
