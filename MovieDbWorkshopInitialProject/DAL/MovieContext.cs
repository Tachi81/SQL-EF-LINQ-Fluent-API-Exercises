using MovieDbWorkshop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbWorkshop.DAL
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=MovieDbConnectionString")
        {

        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<MovieRole> MovieRoles { get; set; }
        public virtual DbSet<MovieStaff> MovieStaff { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(movie => movie.Title).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Movie>().Property(movie => movie.ReleaseDate).HasColumnType("date");

            modelBuilder.Entity<Genre>().Property(genre => genre.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Genre>().HasMany(e => e.Movies).WithMany(e => e.Genres).Map(m => m.ToTable("MovieGenre")
                .MapLeftKey("GenreId").MapRightKey("MovieId"));

            modelBuilder.Entity<Review>().Property(rev => rev.ContentText).IsRequired();
            modelBuilder.Entity<Review>().Property(rev => rev.Author).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Review>().HasRequired(rev => rev.Movie).WithMany(m => m.Reviews).Map(mc => mc.MapKey("MovieId"));

            modelBuilder.Entity<Person>().Property(rev => rev.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Person>().Property(rev => rev.LastName).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<MovieRole>().HasKey(mr => mr.RoleId);
            modelBuilder.Entity<MovieRole>().Property(mr => mr.Name).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<MovieStaff>().HasRequired(ms => ms.Movie).WithMany(m => m.MovieStaff).HasForeignKey(ms => ms.MovieId);
            modelBuilder.Entity<MovieStaff>().HasRequired(ms => ms.Person).WithMany(p => p.MovieStaff).HasForeignKey(ms => ms.PersonId);
            modelBuilder.Entity<MovieStaff>().HasRequired(ms => ms.Role).WithMany(r => r.MovieStaff).HasForeignKey(ms => ms.RoleId);
            modelBuilder.Entity<MovieStaff>().HasKey(ms => new { ms.MovieId, ms.PersonId, ms.RoleId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
