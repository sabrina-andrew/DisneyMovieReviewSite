using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyMovieReviewSite.Migrations
{
    public partial class ChangedMovieModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movies");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageRating",
                table: "Movies",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Movies");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Movies",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
