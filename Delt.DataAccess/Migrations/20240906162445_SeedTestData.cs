using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 6, 19, 54, 44, 686, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "Experience", "Family", "Name", "ProfileImage" },
                values: new object[] { 2, "not to as", 7, ",p", "ali", "null for bnow" });

            migrationBuilder.InsertData(
                table: "Seminars",
                columns: new[] { "Id", "CoverImage", "Level", "Price", "ReleaseTime", "ShortDescription", "TeacherId", "Title" },
                values: new object[] { 2, "null for now", 0, 0.0, new DateTime(2024, 9, 6, 19, 54, 44, 686, DateTimeKind.Local).AddTicks(6698), "dksjjdksjdkjskjdksjdksjdkjskdkjsd", 2, "this is title" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 6, 19, 29, 32, 38, DateTimeKind.Local).AddTicks(4124));
        }
    }
}
