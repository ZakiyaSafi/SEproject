using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grader.Models
{
    public class Mark
    {
        [Key]
        public int markID { get; set; }
        public int studentID { get; set; }
        public int assessmentID { get; set; }
        public double markAchieved { get; set; }
    }
}
