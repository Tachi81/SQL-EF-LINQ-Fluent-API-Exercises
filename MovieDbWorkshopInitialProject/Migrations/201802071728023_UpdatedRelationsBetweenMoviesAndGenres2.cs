namespace MovieDbWorkshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedRelationsBetweenMoviesAndGenres2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MovieGenres", newName: "MovieGenre");
            RenameColumn(table: "dbo.MovieGenre", name: "Movie_MovieId", newName: "MovieId");
            RenameColumn(table: "dbo.MovieGenre", name: "Genre_GenreId", newName: "GenreId");
            RenameIndex(table: "dbo.MovieGenre", name: "IX_Genre_GenreId", newName: "IX_GenreId");
            RenameIndex(table: "dbo.MovieGenre", name: "IX_Movie_MovieId", newName: "IX_MovieId");
            DropPrimaryKey("dbo.MovieGenre");
            AddPrimaryKey("dbo.MovieGenre", new[] { "GenreId", "MovieId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MovieGenre");
            AddPrimaryKey("dbo.MovieGenre", new[] { "Movie_MovieId", "Genre_GenreId" });
            RenameIndex(table: "dbo.MovieGenre", name: "IX_MovieId", newName: "IX_Movie_MovieId");
            RenameIndex(table: "dbo.MovieGenre", name: "IX_GenreId", newName: "IX_Genre_GenreId");
            RenameColumn(table: "dbo.MovieGenre", name: "GenreId", newName: "Genre_GenreId");
            RenameColumn(table: "dbo.MovieGenre", name: "MovieId", newName: "Movie_MovieId");
            RenameTable(name: "dbo.MovieGenre", newName: "MovieGenres");
        }
    }
}
