using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studentfilesystem.Models
{
    public partial class Application
    {
        public Application()
        {
            Document = new HashSet<Document>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public DateTime? BirthDate { get; set; }
        public string SchoolEmail { get; set; }
        public int? PrimaryMobileNo { get; set; }
        public int? KnustmobileNo { get; set; }
        public int? OtherPhoneNo { get; set; }
        public string OtherEmail { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string ResidentialAddress1 { get; set; }
        public string ResidentialAddress2 { get; set; }
        public string ResidentialAddress3 { get; set; }
        public string ResidentialAddress4 { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddress3 { get; set; }
        public string PostalAddress4 { get; set; }
        public string Religion { get; set; }
        public string Denomination { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdateBy { get; set; }
        public string Type { get; set; }
        public string AcademicYear { get; set; }
        public int Status { get; set; }
        public string ProgrammeChoice1 { get; set; }
        public string ProgrammeChoice2 { get; set; }
        public string ProgrammeChoice3 { get; set; }
        public string PassportTitle { get; set; }
        public string PassportPath { get; set; }
        [NotMapped]
        public IFormFile PassportImage { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Document> Document { get; set; }
    }
}
