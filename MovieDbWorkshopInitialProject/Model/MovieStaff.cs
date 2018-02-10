using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbWorkshop.Model
{
    public class MovieStaff
    {
        public virtual Movie Movie { get; set; }
        public virtual Person Person { get; set; }
        public virtual MovieRole Role { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }
    }
}
