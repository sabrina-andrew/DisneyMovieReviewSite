using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyMovieReviewSite.Migrations
{
    public partial class AddedDescriptionInSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "Description",
                value: "Disney classics and newer animated releases.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "Description",
                value: "Computer generated films produced by Pixar.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "Description",
                value: "Includes action involving real people or animals, as contrasted with animation or computer-generated effects.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "Description",
                value: "Animation description");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "Description",
                value: "Pixar description");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "Description",
                value: "Live Action Description");
        }
    }
}
