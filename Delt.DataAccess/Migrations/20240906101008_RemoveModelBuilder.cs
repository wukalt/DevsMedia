using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Delt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveModelBuilder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "BlogText", "CoverImage", "ReleaseTime", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, "SOLID که متشکل از 5 اصل است در برنامه نویسی  بهتر کمک میکمند", "null for now", new DateTime(2024, 9, 6, 3, 37, 36, 692, DateTimeKind.Local).AddTicks(4699), "SOLID که متشکل از 5 اصل است در برنامه نویسی  بهتر کمک میکمند", "چگونه در سی شارپ SOLID را پیاده سازی کنیم" },
                    { 2, "async await که متشک  بهتر کمک میکمند", "null for now", new DateTime(2024, 9, 6, 3, 37, 36, 692, DateTimeKind.Local).AddTicks(4701), "SOLID که متشکل از 5 اصل است در برنامه نویسی  بهتر کمک میکمند", "Asyncronous را پیاده سازی کنیم" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImage", "DownloadLink", "Publisher", "ReleaseTime", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, "Mark J Price", "https://content.packt.com/_/image/original/B19586/cover_image_large.jpg", "www.google.com", "packt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2024), ".NET8  آخرین نسخه اصلی از فریم ورک دات نت است، که پس از انتشار نسخه‌های قبلی، این وعده را به کاربران خود داده است که مجموعه‌ای از ویژگی‌های جدید، پیشرفت‌ها و قابلیت‌های جدید را برای توانمند‌سازی بیشتر توسعه‌دهندگان و ایجاد توسعه برنامه‌های کاربردی و لذت بخش به ارمغان بیاورد", "C# 12 and .NET 8 – Modern Cross-Platform Development Fundamentals Eighth Edition" },
                    { 2, "Mark J Price", "https://content.packt.com/_/image/original/B02765/cover_image_large.jpg", "www.google.com", "packt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2024), ".NET8  آخرین نسخه اصلی از فریم ورک دات نت است، که پس از انتشار نسخه‌های قبلی، این وعده را به کاربران خود داده است که مجموعه‌ای از ویژگی‌های جدید، پیشرفت‌ها و قابلیت‌های جدید را برای توانمند‌سازی بیشتر توسعه‌دهندگان و ایجاد توسعه برنامه‌های کاربردی و لذت بخش به ارمغان بیاورد", "Cyber" }
                });
        }
    }
}
