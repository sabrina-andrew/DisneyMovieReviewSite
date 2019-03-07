using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyMovieReviewSite.Migrations
{
    public partial class AddedMoreSeedDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "MovieID", "ReviewContent", "UserName", "UserRating" },
                values: new object[,]
                {
                    { 5, 5, "This film impressed me right after the first viewing, in August 2003, after which the following followed and so quietly peacefully, imperceptibly, I probably approached the mark of ten views. In principle, it's worth it, this film can already be called a legend, and it's a pleasure to watch such films.", "sofa_king", 4 },
                    { 6, 6, "This film is amazing watched in imax 3d. I watch most comic book movies this way for the last ten years,black panther is on another level for a standalone film the action affects story pacing brilliant never bored once. I wanted to watch it straight away again the only better marvel movie is the original avengers and logan but that isn't really marvel. Trust me don't listen to all the haters and watch this film I'm going to watch it again and I haven't done that with a film since the matrix enough said long live the KING.", "Wakanda_Forever", 5 },
                    { 7, 7, "Alice in Wonderland is, by far, the most inventive and original of all the Disney cartoons. In this zany cartoon, Lewis Carroll's Alice's Adventures in Wonderland and Through the Looking Glass are combined into one strange yet hilarious story. Its characters each have very distinct personalities and are perfectly voiced by some of Hollywood's finest comedians. All in all, this cartoon feature will tickle your funny bone and captivate your senses with its colorful backgrounds and settings. Alice in Wonderland is an exquisite work of art and literature!", "Sam_Sung", 5 },
                    { 8, 8, "If you're up for tear wrenching, heart crunching adventure about the best pals we as humans can have. Then this film is for you. Very good at getting even the most hard boiled egg to sweat a little from their eyes!", "Princess_Evangeline_of_Spirit_Dell", 3 },
                    { 9, 9, "Like a big, hot bowl of mashed potatoes and gravy the homogenized humor of this aggressively wholesome animated movie will fill you up with warm, comfy predigested emotions while blocking any effective critical thinking. It's Disney after all, the entertainment equivalent of Marie Callender's. ... Repeat to make IMD's Minimum lines requirement: Like a big, hot bowl of mashed potatoes and gravy the homogenized humor of this aggressively wholesome animated movie will fill you up with warm, comfy predigested emotions while blocking any effective critical thinking. It's Disney after all, the entertainment equivalent of Marie Callender's.", "Never_Happy", 3 },
                    { 10, 10, "Wow.. This movie is technically breathtaking. The character animations, the scenery and the voices (Samuel Jackson is perfect in his role) are top notch. One can only imagine the thousands of hours that were necessary to create this technical masterpiece. This is another impressing performance from Pixar. The plot of the movie is also both original and entertaining.It manages to be enjoyable for both kids and adults. The pure humor part may not be as strong and consistent as in Finding Nemo but nevertheless Incredibles succeeds in making you smile on several occasions.", "Batman", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 10);
        }
    }
}
