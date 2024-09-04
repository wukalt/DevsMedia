using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevsMedia.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeBlogDataAnotaions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 5, 0, 26, 48, 312, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 5, 0, 26, 48, 312, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 5, 0, 26, 48, 312, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 5, 0, 26, 48, 312, DateTimeKind.Local).AddTicks(6143));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 4, 16, 37, 54, 859, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 4, 16, 37, 54, 859, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 4, 16, 37, 54, 859, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 4, 16, 37, 54, 859, DateTimeKind.Local).AddTicks(7459));
        }
    }
}
