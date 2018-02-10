using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMovies.Models
{
    public class Movies
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int YearOfRelease { get; set; }

        public ICollection<Genre> Genres { get; set; }
    }
}