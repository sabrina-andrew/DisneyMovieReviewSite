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
                    Rating = 5.0,
                    UserName = "Mr. Whiplash",

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
                    Rating = 4.0,
                    UserName = "DisneyFanatic23",
                    
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
                    Rating = 4.0,
                    UserName = "DisneyLover",
                    
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
                    Rating = 4.0,
                    UserName = "DisneyReviewer",
                   
                });

            modelBuilder.Entity<Category>().HasData(

               new Category() { CategoryID = 1, CategoryName = "Animation" , Description = "Animation description"},
               new Category() { CategoryID = 2, CategoryName = "Pixar", Description = "Pixar description" },
               new Category() { CategoryID = 3, CategoryName = "Live Action", Description = "Live Action Description"}
                );

            modelBuilder.Entity<Review>().HasData(

                new Review() { ReviewID = 1, MovieID = 1, ReviewContent = "Ariel is a fiery, independent teenage mermaid who falls in love with a prince. She literally makes a deal with the devil to get her man. I love how sweet Ariel is with Eric, especially when she can't talk! Sebastian, Scuttle, and Flounder are all very funny, the animation, voice-overs and music are incredible! Who can resist the urge to sing and dance to 'Under The Sea'? A fun, enjoyable movie that the whole family will love and treasure." },
                new Review() { ReviewID = 2, MovieID = 2, ReviewContent = "On paper, this marks one of Disney's trickiest films to date. A love story set in the middle east where the supporting characters include a monkey, flying carpet, and a genie (only one of which can talk) doesn't exactly sound like familiar territory . But the animators stay true to form and expand their horizons, especially Clements and Musker who were fresh off their success of The Little Mermaid. The exotic world that the animators portray is intriguing yet also friendly and familiar as they fill it with irresistible characters. Each personality is carefully crafted with several dimensions that make them even more real, especially Jasmine who surprisingly exhibits considerable strength and individuality, a trait that hasn't been prominent in Disney's female characters. And who can forget Genie, the result of the genius that is the late Robin Williams. Williams actually ad-libbed most of his lines and designers animated the characters based off his recordings after. And it is a wonderful performance that solidifies the movie as a classic." },
                new Review() { ReviewID = 3, MovieID = 3, ReviewContent = "Delightful animated feature from Walt Disney Pictures about a naive young lion cub destined for greatness.Born the son of a beloved and authoritative king he's groomed to be the next ruler of the kingdom, but along the way he encounters tragic detours at the hands of his villainous uncle and scheming hyena henchmen. Years later—as an adult—he decides to embrace his destiny and take his proper place in the Circle of Life. Warm, intelligent, laugh-out loud funny film is a triumph in every aspect; unforgettable songs, snappy dialogue, remarkable animation, and a stellar cast of voices make this a treat for all ages. A rousing adventure that you can enjoy again and again, and arguably one of the finest animated films ever made." },
                new Review() { ReviewID = 4, MovieID = 4, ReviewContent = "Toy Story is a sheer delight to view on the screen.The characters are well done, the plot is exceptional, and the best thing of all, the film is entirely produced on the computer.The animation is extraordinary in it's ability to bring such great entertainment to the screen. The film also teaches some good lessons for the kids like friendship (mainly between Woody and Buzz Light-year). Spectacular entertainment all around and one of the best films Disney has come with." }
                );

            base.OnModelCreating(modelBuilder);

        }
    }
}
