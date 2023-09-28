using System;
using System.Collections.Generic;

namespace studentfilesystem.Models
{
    public partial class Programme
    {
        public int ProgrammeId { get; set; }
        public int DepartmentId { get; set; }
        public int FacultyId { get; set; }
        public int CollegeId { get; set; }
        public string ProgrammeName { get; set; }
        public string ProgrammeTag { get; set; }
    }
}
