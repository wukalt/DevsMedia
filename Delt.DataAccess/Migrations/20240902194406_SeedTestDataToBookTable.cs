using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Delt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestDataToBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CoverImage", "ReleaseTime", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, "https://content.packt.com/_/image/original/B19586/cover_image_large.jpg", new DateTime(2024, 9, 2, 23, 14, 5, 192, DateTimeKind.Local).AddTicks(2637), ".NET8  آخرین نسخه اصلی از فریم ورک دات نت است، که پس از انتشار نسخه‌های قبلی، این وعده را به کاربران خود داده است که مجموعه‌ای از ویژگی‌های جدید، پیشرفت‌ها و قابلیت‌های جدید را برای توانمند‌سازی بیشتر توسعه‌دهندگان و ایجاد توسعه برنامه‌های کاربردی و لذت بخش به ارمغان بیاورد", "C# 12 and .NET 8 – Modern Cross-Platform Development Fundamentals Eighth Edition" },
                    { 2, "https://content.packt.com/_/image/original/B02765/cover_image_large.jpg", new DateTime(2024, 9, 2, 23, 14, 5, 192, DateTimeKind.Local).AddTicks(2650), ".NET8  آخرین نسخه اصلی از فریم ورک دات نت است، که پس از انتشار نسخه‌های قبلی، این وعده را به کاربران خود داده است که مجموعه‌ای از ویژگی‌های جدید، پیشرفت‌ها و قابلیت‌های جدید را برای توانمند‌سازی بیشتر توسعه‌دهندگان و ایجاد توسعه برنامه‌های کاربردی و لذت بخش به ارمغان بیاورد", "Cyber" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
