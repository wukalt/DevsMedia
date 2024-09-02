using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevsMedia.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseContentModelAndAddBookModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Admins_CreatorId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CreatorId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CreatorId",
                table: "Blogs",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Admins_CreatorId",
                table: "Blogs",
                column: "CreatorId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
