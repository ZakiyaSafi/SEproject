using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grader.Models
{
    public class CourseCoordinator
    {
        [Key]
        public int courseCoordinatorID { get; set; }
        public string courseCoordinatorNo { get; set; }
        public string courseCoordinatorPassword { get; set; }
    }
}
