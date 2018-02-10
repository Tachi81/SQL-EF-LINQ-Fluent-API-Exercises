using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbWorkshop.Model
{
    public class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }
        public int GenreId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
