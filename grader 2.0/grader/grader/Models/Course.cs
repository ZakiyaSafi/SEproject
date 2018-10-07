using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grader.Models
{
    public class Course
    {
        [Key] 
        public int courseID { get; set; }
        public string courseName { get; set; }
        public string courseCode { get; set; }
        public int courseCoordinatorID { get; set; }
        public int schoolAdministratorID { get; set; }
    }
}
