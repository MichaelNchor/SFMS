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

        public string DepartmentId { get; set; }
        public string FacultyId { get; set; }
        public string CollegeId { get; set; }
        public string DepartmentName { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Programme> Programme { get; set; }
    }
}
