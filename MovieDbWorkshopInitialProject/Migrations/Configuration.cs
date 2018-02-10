namespace MovieDbWorkshop.Migrations
{
    using MovieDbWorkshop.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieDbWorkshop.DAL.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieDbWorkshop.DAL.MovieContext context)
        {

            context.Genres.AddOrUpdate(g => g.Name,
                new Genre() { Name = "Gangster" },
                new Genre() { Name = "Comedy" },
                new Genre() { Name = "Drama" },
                new Genre() { Name = "Sci-Fi" },
                new Genre() { Name = "Western" }
);
            context.Movies.AddOrUpdate(m => m.Title,
            new Movie()
            {
                Title = "Pulp Fiction",
                ReleaseDate = new DateTime(1994, 1, 1),
            },
            new Movie()
            {
                Title = "Django",
                ReleaseDate = new DateTime(2012, 1, 1),
            },
            new Movie()
            {
                Title = "Interstellar",
                ReleaseDate = new DateTime(2014, 1, 1),
            }
            );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
