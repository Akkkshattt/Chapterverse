using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chapterverse.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, "Science Fiction" },
                    { 2, null, 2, "Fiction" },
                    { 3, null, 3, "Horror" },
                    { 4, null, 4, "Fantasy" },
                    { 5, null, 5, "Romance" },
                    { 6, null, 6, "Thriller" },
                    { 7, null, 7, "Mystery" },
                    { 8, null, 8, "Adventure Fiction" },
                    { 9, null, 9, "Comics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
