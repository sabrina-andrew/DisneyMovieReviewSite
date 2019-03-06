using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyMovieReviewSite.Migrations
{
    public partial class AddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "AverageRating", "CategoryID", "ImgPath", "Name", "ReleaseYear", "RunTime", "Synopsis", "UserName" },
                values: new object[] { 10, 0m, 2, "/Images/TheIncredibles.jpg", "The Incredibles", 2004, 115, "A family of undercover superheroes, while trying to live the quiet suburban life, are forced into action to save the world.", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 10);
        }
    }
}
