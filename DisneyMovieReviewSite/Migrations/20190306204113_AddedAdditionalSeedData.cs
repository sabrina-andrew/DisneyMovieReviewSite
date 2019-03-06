using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyMovieReviewSite.Migrations
{
    public partial class AddedAdditionalSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "AverageRating", "CategoryID", "ImgPath", "Name", "ReleaseYear", "RunTime", "Synopsis", "UserName" },
                values: new object[,]
                {
                    { 5, 0m, 3, "/Images/PiratesOfTheCaribbean.jpg", "Pirates of the Caribbean: The Curse of the Black Pearl", 2003, 143, "Blacksmith Will Turner teams up with eccentric pirate 'Captain' Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.", null },
                    { 6, 0m, 3, "/Images/BlackPanther.jpg", "Black Panther", 2018, 133, "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.", null },
                    { 7, 0m, 1, "/Images/AliceInWonderland.jpg", "Alice in Wonderland", 1951, 75, "Alice stumbles into the world of Wonderland. Will she get home? Not if the Queen of Hearts has her way.", null },
                    { 8, 0m, 3, "/Images/HomewardBound.jpg", "Homeward Bound: The Incredible Journey", 1993, 84, "Three pets escape from a California ranch to find their owners in San Francisco.", null },
                    { 9, 0m, 2, "/Images/Up.jpg", "Up", 2009, 96, "Seventy-eight year old Carl Fredricksen travels to Paradise Falls in his home equipped with balloons, inadvertently taking a young stowaway.", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 9);
        }
    }
}
