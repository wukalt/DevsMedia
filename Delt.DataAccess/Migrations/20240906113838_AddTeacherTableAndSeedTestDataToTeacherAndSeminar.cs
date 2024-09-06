using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTeacherTableAndSeedTestDataToTeacherAndSeminar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seminars_Teacher_TeacherId",
                table: "Seminars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teachers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "Experience", "Family", "Name", "ProfileImage" },
                values: new object[] { 1, "not to as", 7, ",p", "ali", "null for bnow" });

            migrationBuilder.InsertData(
                table: "Seminars",
                columns: new[] { "Id", "CoverImage", "Level", "ReleaseTime", "ShortDescription", "TeacherId", "Title" },
                values: new object[] { 1, "null for now", 0, new DateTime(2024, 9, 6, 15, 8, 37, 477, DateTimeKind.Local).AddTicks(8290), "dksjjdksjdkjskjdksjdksjdkjskdkjsd", 1, "this is title" });

            migrationBuilder.AddForeignKey(
                name: "FK_Seminars_Teachers_TeacherId",
                table: "Seminars",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seminars_Teachers_TeacherId",
                table: "Seminars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DeleteData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teacher");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seminars_Teacher_TeacherId",
                table: "Seminars",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
