using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyMovieReviewSite.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 1,
                columns: new[] { "Rating", "UserName" },
                values: new object[] { 0.0, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2,
                columns: new[] { "Rating", "UserName" },
                values: new object[] { 0.0, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 3,
                columns: new[] { "Rating", "UserName" },
                values: new object[] { 0.0, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 4,
                columns: new[] { "Rating", "UserName" },
                values: new object[] { 0.0, null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1,
                columns: new[] { "UserName", "UserRating" },
                values: new object[] { "DisneyReviewer", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2,
                columns: new[] { "UserName", "UserRating" },
                values: new object[] { "DisneyFanatic23", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3,
                columns: new[] { "UserName", "UserRating" },
                values: new object[] { "DisneyLover", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 4,
                columns: new[] { "UserName", "UserRating" },
                values: new object[] { "Mr. Whiplash", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 1,
                columns: new[] { "Rating", "UserName" },
                values: new object[] { 5.0, "Mr. Whiplash" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2,
                columns: new[] { "Rating", "UserName" },
                values: new object[] { 4.0, "DisneyFanatic23" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 3,
                columns: new[] { "Rating", "UserName" },
                values: new object[] { 4.0, "DisneyLover" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 4,
                columns: new[] { "Rating", "UserName" },
                values: new object[] { 4.0, "DisneyReviewer" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1,
                columns: new[] { "UserName", "UserRating" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2,
                columns: new[] { "UserName", "UserRating" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3,
                columns: new[] { "UserName", "UserRating" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 4,
                columns: new[] { "UserName", "UserRating" },
                values: new object[] { null, 0 });
        }
    }
}
