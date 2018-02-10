namespace NewMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixColumnName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "YearOfRelease", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "YearOfRelease123");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "YearOfRelease123", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "YearOfRelease");
        }
    }
}
