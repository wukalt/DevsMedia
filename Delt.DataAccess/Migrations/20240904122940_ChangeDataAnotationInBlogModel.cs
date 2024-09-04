using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataAnotationInBlogModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 3, 22, 53, 59, 523, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 3, 22, 53, 59, 523, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 3, 22, 53, 59, 523, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 3, 22, 53, 59, 523, DateTimeKind.Local).AddTicks(2841));
        }
    }
}
