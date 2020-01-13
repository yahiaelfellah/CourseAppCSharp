using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProjectApp.Migrations
{
    public partial class aspnetuserforeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Organization",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organization_AspNetUserId",
                table: "Organization",
                column: "AspNetUserId");

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Individual",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Individual_AspNetUserId",
                table: "Individual",
                column: "AspNetUserId");

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Hobby",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hobby_AspNetUserId",
                table: "Hobby",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobby_AspNetUsers_AspNetUserId",
                table: "Hobby",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Individual_AspNetUsers_AspNetUserId",
                table: "Individual",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_AspNetUsers_AspNetUserId",
                table: "Organization",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobby_AspNetUsers_AspNetUserId",
                table: "Hobby");

            migrationBuilder.DropForeignKey(
                name: "FK_Individual_AspNetUsers_AspNetUserId",
                table: "Individual");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_AspNetUsers_AspNetUserId",
                table: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Organization_AspNetUserId",
                table: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Individual_AspNetUserId",
                table: "Individual");

            migrationBuilder.DropIndex(
                name: "IX_Hobby_AspNetUserId",
                table: "Hobby");

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Organization",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Individual",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Hobby",
                nullable: true);
        }
    }
}
