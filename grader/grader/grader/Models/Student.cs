using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grader.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        public string studentNo { get; set; }
        public string studentPassword { get; set; }


    }
}
