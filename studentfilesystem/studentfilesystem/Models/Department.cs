using System;
using System.Collections.Generic;

namespace studentfilesystem.Models
{
    public partial class Department
    {
        public Department()
        {
            Programme = new HashSet<Programme>();
        }

        public int DepartmentId { get; set; }
        public int FacultyId { get; set; }
        public int CollegeId { get; set; }
        public string DepartmentName { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Programme> Programme { get; set; }
    }
}
