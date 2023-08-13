using System;
using System.Collections.Generic;

namespace studentfilesystem.Models
{
    public partial class College
    {
        public College()
        {
            Faculty = new HashSet<Faculty>();
        }

        public string CollegeId { get; set; }
        public string CollegeName { get; set; }

        public virtual ICollection<Faculty> Faculty { get; set; }
    }
}
