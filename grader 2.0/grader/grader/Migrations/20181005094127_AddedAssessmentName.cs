using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace grader.Migrations
{
    public partial class AddedAssessmentName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "assessmentName",
                table: "Assessments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "assessmentName",
                table: "Assessments");
        }
    }
}
