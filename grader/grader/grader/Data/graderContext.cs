using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using grader.Models;

namespace grader.Models
{
    public class graderContext : DbContext
    {
        public graderContext (DbContextOptions<graderContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } //was grader.models.student
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCoordinator> CourseCoordinators { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<ReportQuery> ReportQueries { get; set; }
        public DbSet<SchoolAdministrator> SchoolAdministrators { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
