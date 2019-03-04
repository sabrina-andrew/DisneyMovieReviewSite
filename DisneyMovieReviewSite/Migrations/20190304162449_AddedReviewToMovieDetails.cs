using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyMovieReviewSite.Migrations
{
    public partial class AddedReviewToMovieDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovieID = table.Column<int>(nullable: false),
                    ReviewContent = table.Column<string>(nullable: true),
                    UserRating = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "MovieID", "ReviewContent", "UserName", "UserRating" },
                values: new object[,]
                {
                    { 1, 1, "Ariel is a fiery, independent teenage mermaid who falls in love with a prince. She literally makes a deal with the devil to get her man. I love how sweet Ariel is with Eric, especially when she can't talk! Sebastian, Scuttle, and Flounder are all very funny, the animation, voice-overs and music are incredible! Who can resist the urge to sing and dance to 'Under The Sea'? A fun, enjoyable movie that the whole family will love and treasure.", null, 0 },
                    { 2, 2, "On paper, this marks one of Disney's trickiest films to date. A love story set in the middle east where the supporting characters include a monkey, flying carpet, and a genie (only one of which can talk) doesn't exactly sound like familiar territory . But the animators stay true to form and expand their horizons, especially Clements and Musker who were fresh off their success of The Little Mermaid. The exotic world that the animators portray is intriguing yet also friendly and familiar as they fill it with irresistible characters. Each personality is carefully crafted with several dimensions that make them even more real, especially Jasmine who surprisingly exhibits considerable strength and individuality, a trait that hasn't been prominent in Disney's female characters. And who can forget Genie, the result of the genius that is the late Robin Williams. Williams actually ad-libbed most of his lines and designers animated the characters based off his recordings after. And it is a wonderful performance that solidifies the movie as a classic.", null, 0 },
                    { 3, 3, "Delightful animated feature from Walt Disney Pictures about a naive young lion cub destined for greatness.Born the son of a beloved and authoritative king he's groomed to be the next ruler of the kingdom, but along the way he encounters tragic detours at the hands of his villainous uncle and scheming hyena henchmen. Years later—as an adult—he decides to embrace his destiny and take his proper place in the Circle of Life. Warm, intelligent, laugh-out loud funny film is a triumph in every aspect; unforgettable songs, snappy dialogue, remarkable animation, and a stellar cast of voices make this a treat for all ages. A rousing adventure that you can enjoy again and again, and arguably one of the finest animated films ever made.", null, 0 },
                    { 4, 4, "Toy Story is a sheer delight to view on the screen.The characters are well done, the plot is exceptional, and the best thing of all, the film is entirely produced on the computer.The animation is extraordinary in it's ability to bring such great entertainment to the screen. The film also teaches some good lessons for the kids like friendship (mainly between Woody and Buzz Light-year). Spectacular entertainment all around and one of the best films Disney has come with.", null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MovieID",
                table: "Reviews",
                column: "MovieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Movies",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 1,
                column: "Review",
                value: "Ariel is a fiery, independent teenage mermaid who falls in love with a prince. She literally makes a deal with the devil to get her man. I love how sweet Ariel is with Eric, especially when she can't talk! Sebastian, Scuttle, and Flounder are all very funny, the animation, voice-overs and music are incredible! Who can resist the urge to sing and dance to 'Under The Sea'? A fun, enjoyable movie that the whole family will love and treasure.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2,
                column: "Review",
                value: "On paper, this marks one of Disney's trickiest films to date. A love story set in the middle east where the supporting characters include a monkey, flying carpet, and a genie (only one of which can talk) doesn't exactly sound like familiar territory . But the animators stay true to form and expand their horizons, especially Clements and Musker who were fresh off their success of The Little Mermaid. The exotic world that the animators portray is intriguing yet also friendly and familiar as they fill it with irresistible characters. Each personality is carefully crafted with several dimensions that make them even more real, especially Jasmine who surprisingly exhibits considerable strength and individuality, a trait that hasn't been prominent in Disney's female characters. And who can forget Genie, the result of the genius that is the late Robin Williams. Williams actually ad-libbed most of his lines and designers animated the characters based off his recordings after. And it is a wonderful performance that solidifies the movie as a classic.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 3,
                column: "Review",
                value: "Delightful animated feature from Walt Disney Pictures about a naive young lion cub destined for greatness. Born the son of a beloved and authoritative king he's groomed to be the next ruler of the kingdom, but along the way he encounters tragic detours at the hands of his villainous uncle and scheming hyena henchmen. Years later—as an adult—he decides to embrace his destiny and take his proper place in the Circle of Life. Warm, intelligent, laugh-out loud funny film is a triumph in every aspect; unforgettable songs, snappy dialogue, remarkable animation, and a stellar cast of voices make this a treat for all ages. A rousing adventure that you can enjoy again and again, and arguably one of the finest animated films ever made.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 4,
                column: "Review",
                value: "Toy Story is a sheer delight to view on the screen. The characters are well done, the plot is exceptional, and the best thing of all, the film is entirely produced on the computer. The animation is extraordinary in it's ability to bring such great entertainment to the screen. The film also teaches some good lessons for the kids like friendship (mainly between Woody and Buzz Light-year). Spectacular entertainment all around and one of the best films Disney has come with.");
        }
    }
}
