using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Delt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestDataToBlogTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "BlogText", "CoverImage", "ReleaseTime", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, "SOLID که متشکل از 5 اصل است در برنامه نویسی  بهتر کمک میکمند", "null for now", new DateTime(2024, 9, 3, 22, 53, 59, 523, DateTimeKind.Local).AddTicks(2997), "SOLID که متشکل از 5 اصل است در برنامه نویسی  بهتر کمک میکمند", "چگونه در سی شارپ SOLID را پیاده سازی کنیم" },
                    { 2, "async await که متشک  بهتر کمک میکمند", "null for now", new DateTime(2024, 9, 3, 22, 53, 59, 523, DateTimeKind.Local).AddTicks(2999), "SOLID که متشکل از 5 اصل است در برنامه نویسی  بهتر کمک میکمند", "Asyncronous را پیاده سازی کنیم" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 2, 23, 14, 5, 192, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 2, 23, 14, 5, 192, DateTimeKind.Local).AddTicks(2650));
        }
    }
}
