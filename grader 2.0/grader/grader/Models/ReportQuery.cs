using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grader.Models
{
    public class ReportQuery
    {
        public int reportQueryID { get; set; }
        public int studentID { get; set; }
        public string reportQueryNature { get; set; }
        public string reportQueryReason { get; set; }
        public bool reportQueryValid { get; set; }
    }
}
