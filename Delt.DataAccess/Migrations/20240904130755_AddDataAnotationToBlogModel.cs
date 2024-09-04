using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAnotationToBlogModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 4, 15, 59, 37, 909, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 4, 15, 59, 37, 909, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 4, 15, 59, 37, 909, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 4, 15, 59, 37, 909, DateTimeKind.Local).AddTicks(1563));
        }
    }
}
