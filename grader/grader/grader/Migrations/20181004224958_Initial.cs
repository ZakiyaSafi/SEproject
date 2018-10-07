using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace grader.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    assessmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    assessmentTotalMark = table.Column<int>(nullable: false),
                    assessmentWeighting = table.Column<double>(nullable: false),
                    courseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.assessmentID);
                });

            migrationBuilder.CreateTable(
                name: "CourseCoordinators",
                columns: table => new
                {
                    courseCoordinatorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    courseCoordinatorNo = table.Column<string>(nullable: true),
                    courseCoordinatorPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCoordinators", x => x.courseCoordinatorID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    courseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    courseCode = table.Column<string>(nullable: true),
                    courseCoordinatorID = table.Column<int>(nullable: false),
                    courseName = table.Column<string>(nullable: true),
                    schoolAdministratorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.courseID);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    markID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    assessmentID = table.Column<int>(nullable: false),
                    markAchieved = table.Column<double>(nullable: false),
                    studentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.markID);
                });

            migrationBuilder.CreateTable(
                name: "ReportQueries",
                columns: table => new
                {
                    reportQueryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    reportQueryNature = table.Column<string>(nullable: true),
                    reportQueryReason = table.Column<string>(nullable: true),
                    reportQueryValid = table.Column<bool>(nullable: false),
                    studentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportQueries", x => x.reportQueryID);
                });

            migrationBuilder.CreateTable(
                name: "SchoolAdministrators",
                columns: table => new
                {
                    schoolAdministratorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    schoolAdministratorNo = table.Column<string>(nullable: true),
                    schoolAdministratorPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolAdministrators", x => x.schoolAdministratorID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    studentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    studentNo = table.Column<string>(nullable: true),
                    studentPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.studentID);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    studentCourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    courseID = table.Column<int>(nullable: false),
                    studentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => x.studentCourseID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "CourseCoordinators");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "ReportQueries");

            migrationBuilder.DropTable(
                name: "SchoolAdministrators");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "StudentCourses");
        }
    }
}
