using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditTestDataOnSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverImage", "ReleaseTime" },
                values: new object[] { "https://maktabkhooneh.org/mag/wp-content/uploads/2021/06/Application-of-C-programming-language-2.png", new DateTime(2024, 9, 7, 16, 13, 45, 22, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 16, 13, 45, 22, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 16, 13, 45, 22, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 16, 13, 45, 22, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 16, 13, 45, 22, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 16, 13, 45, 22, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 16, 13, 45, 22, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverImage", "ReleaseTime" },
                values: new object[] { "https://rayamarketing.com/uploads/files/panelUpload/60bde783a90e5a56ce11502a23d7cfe5.png", new DateTime(2024, 9, 7, 16, 13, 45, 22, DateTimeKind.Local).AddTicks(7495) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverImage", "ReleaseTime" },
                values: new object[] { "https://miro.medium.com/v2/resize:fit:1400/1*cO88NfVEK4h0uUIuqsVaPQ.png", new DateTime(2024, 9, 7, 15, 46, 6, 827, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 15, 46, 6, 827, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 15, 46, 6, 827, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 15, 46, 6, 827, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 15, 46, 6, 827, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 15, 46, 6, 827, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 7, 15, 46, 6, 827, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverImage", "ReleaseTime" },
                values: new object[] { "https://miro.medium.com/v2/resize:fit:1200/0*M4bxiCIjcTK-2Xr6.jpeg", new DateTime(2024, 9, 7, 15, 46, 6, 827, DateTimeKind.Local).AddTicks(4851) });
        }
    }
}
