using grader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grader.Data
{
    public class DbInitializer
    {
        public static void Initialize(graderContext context)
        {
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student { studentID = 1, studentNo = "1086532", studentPassword = "password"},
                new Student { studentID = 2, studentNo = "1325690", studentPassword = "password2"},
                new Student { studentID = 3, studentNo = "1256092", studentPassword = "password3"},
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courseCoordinators = new CourseCoordinator[]
            {
                new CourseCoordinator {courseCoordinatorID = 1, courseCoordinatorNo = "826098", courseCoordinatorPassword = "CCpassword"},
                new CourseCoordinator {courseCoordinatorID = 2, courseCoordinatorNo = "874071", courseCoordinatorPassword = "CCpassword2"}
            };

            foreach (CourseCoordinator c in courseCoordinators)
            {
                context.CourseCoordinators.Add(c);
            }
            context.SaveChanges();

            var schoolAdministrators = new SchoolAdministrator[]
            {
                new SchoolAdministrator {schoolAdministratorID = 1, schoolAdministratorNo = "7609433", schoolAdministratorPassword = "SApassword"}
            };

            foreach (SchoolAdministrator s in schoolAdministrators)
            {
                context.SchoolAdministrators.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course { courseID = 1, courseName = "Software Engineering 3", courseCode = "COMS3002", courseCoordinatorID = 1, schoolAdministratorID = 1 },
                new Course { courseID = 2, courseName = "Advanced Analysis of Algorithms 3", courseCode = "COMS3005", courseCoordinatorID = 1, schoolAdministratorID = 1},
                new Course { courseID = 3, courseName = "Machine Learning 3", courseCode = "COMS3007", courseCoordinatorID = 2, schoolAdministratorID = 1}
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var studentCourses = new StudentCourse[]
            {
                new StudentCourse { studentCourseID = 1, studentID = 1, courseID = 1},
                new StudentCourse { studentCourseID = 2, studentID = 1, courseID = 2},
                new StudentCourse { studentCourseID = 3, studentID = 1, courseID = 3},
                new StudentCourse { studentCourseID = 4, studentID = 2, courseID = 1},
                new StudentCourse { studentCourseID = 5, studentID = 2, courseID = 2},
                new StudentCourse { studentCourseID = 6, studentID = 2, courseID = 3},
                new StudentCourse { studentCourseID = 7, studentID = 3, courseID = 1},
                new StudentCourse { studentCourseID = 8, studentID = 3, courseID = 2},
                new StudentCourse { studentCourseID = 9, studentID = 3, courseID = 3},
            };

            foreach (StudentCourse c in studentCourses)
            {
                context.StudentCourses.Add(c);
            }
            context.SaveChanges();

            var assessments = new Assessment[]
            {
                new Assessment { assessmentID = 1, courseID = 1, assessmentTotalMark = 45, assessmentWeighting = 0.20, assessmentName = "Test 1" },
                new Assessment { assessmentID = 2, courseID = 1, assessmentTotalMark = 45, assessmentWeighting = 0.20, assessmentName = "Test 2" },
                new Assessment { assessmentID = 3, courseID = 1, assessmentTotalMark = 100, assessmentWeighting = 0.20, assessmentName = "Assignment"},
                new Assessment { assessmentID = 4, courseID = 1, assessmentTotalMark = 20, assessmentWeighting = 0.15, assessmentName = "Presentation"},
                new Assessment { assessmentID = 5, courseID = 2, assessmentTotalMark = 50, assessmentWeighting = 0.30, assessmentName = "Test"},
                new Assessment { assessmentID = 6, courseID = 2, assessmentTotalMark = 150, assessmentWeighting = 0.45, assessmentName = "Lab Exam"},
                new Assessment { assessmentID = 7, courseID = 2, assessmentTotalMark = 150, assessmentWeighting = 0.45, assessmentName = "Final Exam"},
                new Assessment { assessmentID = 8, courseID = 3, assessmentTotalMark = 100, assessmentWeighting = 0.4, assessmentName = "Assignment"},
                new Assessment { assessmentID = 9, courseID = 3, assessmentTotalMark = 100, assessmentWeighting = 0.6, assessmentName = "Exam"}
            };

            foreach (Assessment a in assessments)
            {
                context.Assessments.Add(a);
            }
            context.SaveChanges();

            var marks = new Mark[]
            {
                new Mark { markID = 1, assessmentID = 1, studentID = 1, markAchieved = 28},
                new Mark { markID = 2, assessmentID = 1, studentID = 2, markAchieved = 38},
                new Mark { markID = 3, assessmentID = 1, studentID = 3, markAchieved = 13},

                new Mark { markID = 4, assessmentID = 2, studentID = 1, markAchieved = 29},
                new Mark { markID = 5, assessmentID = 2, studentID = 2, markAchieved = 42},
                new Mark { markID = 6, assessmentID = 2, studentID = 3, markAchieved = 17},

                new Mark { markID = 7, assessmentID = 3, studentID = 1, markAchieved = 66},
                new Mark { markID = 8, assessmentID = 3, studentID = 2, markAchieved = 72},
                new Mark { markID = 9, assessmentID = 3, studentID = 3, markAchieved = 59},

                new Mark { markID = 10, assessmentID = 4, studentID = 1, markAchieved = 19},
                new Mark { markID = 11, assessmentID = 4, studentID = 2, markAchieved = 15},
                new Mark { markID = 12, assessmentID = 4, studentID = 3, markAchieved = 16},

                new Mark { markID = 13, assessmentID = 5, studentID = 1, markAchieved = 26},
                new Mark { markID = 14, assessmentID = 5, studentID = 2, markAchieved = 21},
                new Mark { markID = 15, assessmentID = 5, studentID = 3, markAchieved = 17},

                new Mark { markID = 16, assessmentID = 6, studentID = 1, markAchieved = 103},
                new Mark { markID = 17, assessmentID = 6, studentID = 2, markAchieved = 67},
                new Mark { markID = 18, assessmentID = 6, studentID = 3, markAchieved = 82},

                new Mark { markID = 19, assessmentID = 7, studentID = 1, markAchieved = 125},
                new Mark { markID = 20, assessmentID = 7, studentID = 2, markAchieved = 101},
                new Mark { markID = 21, assessmentID = 7, studentID = 3, markAchieved = 60},

                new Mark { markID = 22, assessmentID = 8, studentID = 1, markAchieved = 66},
                new Mark { markID = 23, assessmentID = 8, studentID = 2, markAchieved = 52},
                new Mark { markID = 24, assessmentID = 8, studentID = 3, markAchieved = 31},

                new Mark { markID = 25, assessmentID = 9, studentID = 1, markAchieved = 62},
                new Mark { markID = 26, assessmentID = 9, studentID = 2, markAchieved = 69},
                new Mark { markID = 27, assessmentID = 9, studentID = 3, markAchieved = 57}
            };

            foreach (Mark m in marks)
            {
                context.Marks.Add(m);
            }
            context.SaveChanges();

            var reportQueries = new ReportQuery[]
            {
                new ReportQuery { reportQueryID = 1, studentID = 3, reportQueryNature = "offence", reportQueryReason = "Plaigirism", reportQueryValid = true}
            };

            foreach (ReportQuery m in reportQueries)
            {
                context.ReportQueries.Add(m);
            }
            context.SaveChanges();

        }
    }
}
