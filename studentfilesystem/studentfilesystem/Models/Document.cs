using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studentfilesystem.Models
{
    public partial class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DocumentPath { get; set; }
        [NotMapped]
        public IFormFile DocumentFile { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int ApplicationId { get; set; }

        //public virtual Application Application { get; set; }
    }
}
