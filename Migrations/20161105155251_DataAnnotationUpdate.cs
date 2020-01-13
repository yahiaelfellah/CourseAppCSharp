using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProjectApp.Migrations
{
    public partial class DataAnnotationUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Individuals",
                table: "Individuals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organization",
                table: "Organizations",
                column: "OrganizationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Individual",
                table: "Individuals",
                column: "IndividualId");

            migrationBuilder.RenameTable(
                name: "Organizations",
                newName: "Organization");

            migrationBuilder.RenameTable(
                name: "Individuals",
                newName: "Individual");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Organization",
                table: "Organization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Individual",
                table: "Individual");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizations",
                table: "Organization",
                column: "OrganizationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Individuals",
                table: "Individual",
                column: "IndividualId");

            migrationBuilder.RenameTable(
                name: "Organization",
                newName: "Organizations");

            migrationBuilder.RenameTable(
                name: "Individual",
                newName: "Individuals");
        }
    }
}
