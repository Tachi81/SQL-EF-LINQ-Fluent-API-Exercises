namespace NewMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedgenresclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.MoviesGenre",
                c => new
                    {
                        Movies_MovieId = c.Int(nullable: false),
                        Genre_GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movies_MovieId, t.Genre_GenreId })
                .ForeignKey("dbo.Movies", t => t.Movies_MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Genre", t => t.Genre_GenreId, cascadeDelete: true)
                .Index(t => t.Movies_MovieId)
                .Index(t => t.Genre_GenreId);
            
            AddColumn("dbo.Movies", "YearOfRelease123", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "YearOfRelease");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "YearOfRelease", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.MoviesGenre", "Genre_GenreId", "dbo.Genre");
            DropForeignKey("dbo.MoviesGenre", "Movies_MovieId", "dbo.Movies");
            DropIndex("dbo.MoviesGenre", new[] { "Genre_GenreId" });
            DropIndex("dbo.MoviesGenre", new[] { "Movies_MovieId" });
            DropColumn("dbo.Movies", "YearOfRelease123");
            DropTable("dbo.MoviesGenre");
            DropTable("dbo.Genre");
        }
    }
}
