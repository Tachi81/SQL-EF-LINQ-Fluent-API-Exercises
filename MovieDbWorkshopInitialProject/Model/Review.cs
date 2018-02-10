using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbWorkshop.Model
{
    public class Review
    {
        
        public int ReviewId { get; set; }
        public string ReviewSite { get; set; }
        public string ContentText { get; set; }
        public int Score { get; set; }
        public string Author { get; set; }
        public virtual Movie Movie { get; set; }
    }
}

