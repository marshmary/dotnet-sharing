using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "Title" },
                values: new object[] { 1, "Author 1", new DateTime(2024, 3, 2, 14, 34, 40, 976, DateTimeKind.Local).AddTicks(9764), "Book 1" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "Title" },
                values: new object[] { 2, "Author 2", new DateTime(2024, 3, 2, 14, 34, 40, 976, DateTimeKind.Local).AddTicks(9783), "Book 2" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublishDate", "Title" },
                values: new object[] { 3, "Author 3", new DateTime(2024, 3, 2, 14, 34, 40, 976, DateTimeKind.Local).AddTicks(9784), "Book 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
