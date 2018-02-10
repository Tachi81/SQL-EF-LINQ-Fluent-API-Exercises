using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbWorkshop.Model
{
    public class MovieRole
    {
        public MovieRole()
        {
        }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MovieStaff> MovieStaff { get; set; }
    }
}
