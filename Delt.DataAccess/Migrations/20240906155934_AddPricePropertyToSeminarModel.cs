using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPricePropertyToSeminarModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Seminars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ReleaseTime" },
                values: new object[] { 0.0, new DateTime(2024, 9, 6, 19, 29, 32, 38, DateTimeKind.Local).AddTicks(4124) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Seminars");

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseTime",
                value: new DateTime(2024, 9, 6, 15, 8, 37, 477, DateTimeKind.Local).AddTicks(8290));
        }
    }
}
