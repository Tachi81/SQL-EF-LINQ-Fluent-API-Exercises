using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbWorkshop.Model
{
    public class Movie
    {
        public Movie()
        {
            Genres = new HashSet<Genre>();
            Reviews = new HashSet<Review>();
        }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<MovieStaff> MovieStaff { get; set; }
    }
}

