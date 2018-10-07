using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grader.Models
{
    public class Assessment
    {
        [Key] 
        public int assessmentID { get; set; }
        public int courseID { get; set; }
        public int assessmentTotalMark { get; set; }
        public double assessmentWeighting { get; set; } 
        public string assessmentName { get; set; }
    }
}
