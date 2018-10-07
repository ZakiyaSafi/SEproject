using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grader.Models
{
    public class SchoolAdministrator
    {
        [Key]
        public int schoolAdministratorID { get; set; }
        public string schoolAdministratorNo { get; set; }
        public string schoolAdministratorPassword { get; set; }
    }
}
