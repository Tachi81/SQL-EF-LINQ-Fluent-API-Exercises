using MovieDbWorkshop.DAL;
using MovieDbWorkshop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            AddReview("Django");

            Console.WriteLine("done" +
                "");
        }

        private static void AddReview(string title)
        {
            using (MovieContext DbContext = new MovieContext())
            {
                var myReview = new Review();
                myReview.Movie = DbContext.Movies.Where(m => m.Title.Equals(title)).First();
                myReview.ContentText = "Calkiem fajny film";
                myReview.Author = "Killer Reviewer";
                myReview.Score = 9;
               
                DbContext.Movies.First(m => m.Title.Equals(title)).Reviews.Add(myReview);

                DbContext.SaveChanges();



            }
        }
    }
}
