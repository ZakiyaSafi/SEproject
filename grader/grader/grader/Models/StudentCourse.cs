using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grader.Models
{
    public class StudentCourse
    {
        [Key]
        public int studentCourseID { get; set; }
        public int studentID { get; set; }
        public int courseID { get; set; }
    }
}
