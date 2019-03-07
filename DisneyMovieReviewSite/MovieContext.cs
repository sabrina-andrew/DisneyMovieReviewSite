using DisneyMovieReviewSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MovieReview;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(

                new Movie()
                {
                    MovieID = 1,
                    Name = "The Little Mermaid",
                    ImgPath = "/Images/TheLittleMermaid.jpg",
                    Synopsis = "A mermaid named Ariel falls in love with a human prince, and must find her destiny with the help of family and friends.",
                    ReleaseYear = 1989,
                    CategoryID = 1,
                    RunTime = 85,
                },


                new Movie()
                {
                    MovieID = 2,
                    Name = "Aladdin",
                    ImgPath = "/Images/Aladdin.jpeg",
                    Synopsis = "Aladdin, a streetwise nobody from the land of Agrabah, finds a magical lamp that will allow his every wish to be granted. He must find a way to stop the evil Jafar and win the love of Princess Jasmine.",
                    ReleaseYear = 1992,
                    CategoryID = 1,
                    RunTime = 91,
                },

                new Movie()
                {
                    MovieID = 3,
                    Name = "Lion King",
                    ImgPath = "/Images/LionKing.jpeg",
                    Synopsis = "Simba is a young lion set to inherit the kingdom from his father, Mufasa. When Simba's evil uncle Scar betrays him, Simba escapes into exile, and must find the courage to reclaim his birthright.",
                    ReleaseYear = 1994,
                    CategoryID = 1,
                    RunTime = 89,
                },

                new Movie()
                {
                    MovieID = 4,
                    Name = "Toy Story",
                    ImgPath = "/Images/ToyStory.jpg",
                    Synopsis = "A cowboy doll is profoundly threatened and jealous when a new spaceman figure supplants him as top toy in a boy's room.",
                    ReleaseYear = 1995,
                    CategoryID = 2,
                    RunTime = 81,
                },
                    new Movie()
                    {
                        MovieID = 5,
                        Name = "Pirates of the Caribbean: The Curse of the Black Pearl",
                        ImgPath = "/Images/PiratesOfTheCaribbean.jpg",
                        Synopsis = "Blacksmith Will Turner teams up with eccentric pirate 'Captain' Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.",
                        ReleaseYear = 2003,
                        CategoryID = 3,
                        RunTime = 143
                    },
                    new Movie()
                    {
                        MovieID = 6,
                        Name = "Black Panther",
                        ImgPath = "/Images/BlackPanther.jpg",
                        Synopsis = "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.",
                        ReleaseYear = 2018,
                        CategoryID = 3,
                        RunTime = 133
                    },
                    new Movie()
                    {
                        MovieID = 7,
                        Name = "Alice in Wonderland",
                        ImgPath = "/Images/AliceInWonderland.jpg",
                        Synopsis = "Alice stumbles into the world of Wonderland. Will she get home? Not if the Queen of Hearts has her way.",
                        ReleaseYear = 1951,
                        CategoryID = 1,
                        RunTime = 75

                    },
                    new Movie()
                    {
                        MovieID = 8,
                        Name = "Homeward Bound: The Incredible Journey",
                        ImgPath = "/Images/HomewardBound.jpg",
                        Synopsis = "Three pets escape from a California ranch to find their owners in San Francisco.",
                        ReleaseYear = 1993,
                        CategoryID = 3,
                        RunTime = 84

                    },
                    new Movie()
                    {
                        MovieID = 9,
                        Name = "Up",
                        ImgPath = "/Images/Up.jpg",
                        Synopsis = "Seventy-eight year old Carl Fredricksen travels to Paradise Falls in his home equipped with balloons, inadvertently taking a young stowaway.",
                        ReleaseYear = 2009,
                        CategoryID = 2,
                        RunTime = 96

                    },
                    new Movie()
                    {
                        MovieID = 10,
                        Name = "The Incredibles",
                        ImgPath = "/Images/TheIncredibles.jpg",
                        Synopsis = "A family of undercover superheroes, while trying to live the quiet suburban life, are forced into action to save the world.",
                        ReleaseYear = 2004,
                        CategoryID = 2,
                        RunTime = 115
                    });


            modelBuilder.Entity<Category>().HasData(

               new Category() { CategoryID = 1, CategoryName = "Animation", Description = "Animation description" },
               new Category() { CategoryID = 2, CategoryName = "Pixar", Description = "Pixar description" },
               new Category() { CategoryID = 3, CategoryName = "Live Action", Description = "Live Action Description" }
                );

            modelBuilder.Entity<Review>().HasData(

                new Review() { ReviewID = 1, MovieID = 1, ReviewContent = "Ariel is a fiery, independent teenage mermaid who falls in love with a prince. She literally makes a deal with the devil to get her man. I love how sweet Ariel is with Eric, especially when she can't talk! Sebastian, Scuttle, and Flounder are all very funny, the animation, voice-overs and music are incredible! Who can resist the urge to sing and dance to 'Under The Sea'? A fun, enjoyable movie that the whole family will love and treasure.", UserRating = 5, UserName = "DisneyReviewer", },

                new Review()
                {
                    ReviewID = 2,
                    MovieID = 2,
                    ReviewContent = "On paper, this marks one of Disney's trickiest films to date. A love story set in the middle east where the supporting characters include a monkey, flying carpet, and a genie (only one of which can talk) doesn't exactly sound like familiar territory . But the animators stay true to form and expand their horizons, especially Clements and Musker who were fresh off their success of The Little Mermaid. The exotic world that the animators portray is intriguing yet also friendly and familiar as they fill it with irresistible characters. Each personality is carefully crafted with several dimensions that make them even more real, especially Jasmine who surprisingly exhibits considerable strength and individuality, a trait that hasn't been prominent in Disney's female characters. And who can forget Genie, the result of the genius that is the late Robin Williams. Williams actually ad-libbed most of his lines and designers animated the characters based off his recordings after. And it is a wonderful performance that solidifies the movie as a classic.",
                    UserRating = 4,
                    UserName = "DisneyFanatic23"
                },
                new Review() { ReviewID = 3, MovieID = 3, ReviewContent = "Delightful animated feature from Walt Disney Pictures about a naive young lion cub destined for greatness.Born the son of a beloved and authoritative king he's groomed to be the next ruler of the kingdom, but along the way he encounters tragic detours at the hands of his villainous uncle and scheming hyena henchmen. Years later—as an adult—he decides to embrace his destiny and take his proper place in the Circle of Life. Warm, intelligent, laugh-out loud funny film is a triumph in every aspect; unforgettable songs, snappy dialogue, remarkable animation, and a stellar cast of voices make this a treat for all ages. A rousing adventure that you can enjoy again and again, and arguably one of the finest animated films ever made.", UserRating = 4, UserName = "DisneyLover" },
                new Review() { ReviewID = 4, MovieID = 4, ReviewContent = "Toy Story is a sheer delight to view on the screen.The characters are well done, the plot is exceptional, and the best thing of all, the film is entirely produced on the computer.The animation is extraordinary in it's ability to bring such great entertainment to the screen. The film also teaches some good lessons for the kids like friendship (mainly between Woody and Buzz Light-year). Spectacular entertainment all around and one of the best films Disney has come with.", UserRating = 4, UserName = "Mr. Whiplash" },
                new Review() { ReviewID = 5, MovieID = 5, ReviewContent = "This film impressed me right after the first viewing, in August 2003, after which the following followed and so quietly peacefully, imperceptibly, I probably approached the mark of ten views. In principle, it's worth it, this film can already be called a legend, and it's a pleasure to watch such films.", UserRating = 4, UserName = "sofa_king" },

                 new Review() { ReviewID = 6, MovieID = 6, ReviewContent = "This film is amazing watched in imax 3d. I watch most comic book movies this way for the last ten years,black panther is on another level for a standalone film the action affects story pacing brilliant never bored once. I wanted to watch it straight away again the only better marvel movie is the original avengers and logan but that isn't really marvel. Trust me don't listen to all the haters and watch this film I'm going to watch it again and I haven't done that with a film since the matrix enough said long live the KING.", UserRating = 5, UserName = "Wakanda_Forever" },
                 new Review() { ReviewID = 7, MovieID = 7, ReviewContent = "Alice in Wonderland is, by far, the most inventive and original of all the Disney cartoons. In this zany cartoon, Lewis Carroll's Alice's Adventures in Wonderland and Through the Looking Glass are combined into one strange yet hilarious story. Its characters each have very distinct personalities and are perfectly voiced by some of Hollywood's finest comedians. All in all, this cartoon feature will tickle your funny bone and captivate your senses with its colorful backgrounds and settings. Alice in Wonderland is an exquisite work of art and literature!", UserRating = 5, UserName = "Sam_Sung" },
                 new Review() { ReviewID = 8, MovieID = 8, ReviewContent = "If you're up for tear wrenching, heart crunching adventure about the best pals we as humans can have. Then this film is for you. Very good at getting even the most hard boiled egg to sweat a little from their eyes!", UserRating = 3, UserName = "Princess_Evangeline_of_Spirit_Dell" },
                 new Review() { ReviewID = 9, MovieID = 9, ReviewContent = "Like a big, hot bowl of mashed potatoes and gravy the homogenized humor of this aggressively wholesome animated movie will fill you up with warm, comfy predigested emotions while blocking any effective critical thinking. It's Disney after all, the entertainment equivalent of Marie Callender's. ... Repeat to make IMD's Minimum lines requirement: Like a big, hot bowl of mashed potatoes and gravy the homogenized humor of this aggressively wholesome animated movie will fill you up with warm, comfy predigested emotions while blocking any effective critical thinking. It's Disney after all, the entertainment equivalent of Marie Callender's.", UserRating = 3 , UserName = "Never_Happy" },
                 new Review() { ReviewID = 10, MovieID = 10, ReviewContent = "Wow.. This movie is technically breathtaking. The character animations, the scenery and the voices (Samuel Jackson is perfect in his role) are top notch. One can only imagine the thousands of hours that were necessary to create this technical masterpiece. This is another impressing performance from Pixar. The plot of the movie is also both original and entertaining.It manages to be enjoyable for both kids and adults. The pure humor part may not be as strong and consistent as in Finding Nemo but nevertheless Incredibles succeeds in making you smile on several occasions.", UserRating = 3, UserName = "Batman" }
                );

            base.OnModelCreating(modelBuilder);

        }
    }
}
