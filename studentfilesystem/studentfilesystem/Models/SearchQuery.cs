using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentfilesystem.Models
{
    public class SearchQuery
    {
        public int SearchQueryId { get; set; }
        public string text { get; set; }
        public string programme { get; set; }
        public string department { get; set; }
        public string college { get; set; }
        public int startDate { get; set; }
        public int endDate { get; set; }
    }
}
