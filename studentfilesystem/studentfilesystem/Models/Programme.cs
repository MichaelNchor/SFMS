using System;
using System.Collections.Generic;

namespace studentfilesystem.Models
{
    public partial class Programme
    {
        public string ProgrammeId { get; set; }
        public string DepartmentId { get; set; }
        public string FacultyId { get; set; }
        public string CollegeId { get; set; }
        public string ProgrammeName { get; set; }
        public string ProgrammeTag { get; set; }

        public virtual Department Department { get; set; }
    }
}
