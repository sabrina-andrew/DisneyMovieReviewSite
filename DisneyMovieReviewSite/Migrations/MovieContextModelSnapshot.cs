﻿// <auto-generated />
using DisneyMovieReviewSite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DisneyMovieReviewSite.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DisneyMovieReviewSite.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryID = 1, CategoryName = "Animation", Description = "Disney classics and newer animated releases." },
                        new { CategoryID = 2, CategoryName = "Pixar", Description = "Computer generated films produced by Pixar." },
                        new { CategoryID = 3, CategoryName = "Live Action", Description = "Includes action involving real people or animals, as contrasted with animation or computer-generated effects." }
                    );
                });

            modelBuilder.Entity("DisneyMovieReviewSite.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AverageRating");

                    b.Property<int>("CategoryID");

                    b.Property<string>("ImgPath");

                    b.Property<string>("Name");

                    b.Property<int>("ReleaseYear");

                    b.Property<int>("RunTime");

                    b.Property<string>("Synopsis");

                    b.Property<string>("UserName");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Movies");

                    b.HasData(
                        new { MovieID = 1, AverageRating = 0m, CategoryID = 1, ImgPath = "/Images/TheLittleMermaid.jpg", Name = "The Little Mermaid", ReleaseYear = 1989, RunTime = 85, Synopsis = "A mermaid named Ariel falls in love with a human prince, and must find her destiny with the help of family and friends." },
                        new { MovieID = 2, AverageRating = 0m, CategoryID = 1, ImgPath = "/Images/Aladdin.jpeg", Name = "Aladdin", ReleaseYear = 1992, RunTime = 91, Synopsis = "Aladdin, a streetwise nobody from the land of Agrabah, finds a magical lamp that will allow his every wish to be granted. He must find a way to stop the evil Jafar and win the love of Princess Jasmine." },
                        new { MovieID = 3, AverageRating = 0m, CategoryID = 1, ImgPath = "/Images/LionKing.jpeg", Name = "Lion King", ReleaseYear = 1994, RunTime = 89, Synopsis = "Simba is a young lion set to inherit the kingdom from his father, Mufasa. When Simba's evil uncle Scar betrays him, Simba escapes into exile, and must find the courage to reclaim his birthright." },
                        new { MovieID = 4, AverageRating = 0m, CategoryID = 2, ImgPath = "/Images/ToyStory.jpg", Name = "Toy Story", ReleaseYear = 1995, RunTime = 81, Synopsis = "A cowboy doll is profoundly threatened and jealous when a new spaceman figure supplants him as top toy in a boy's room." },
                        new { MovieID = 5, AverageRating = 0m, CategoryID = 3, ImgPath = "/Images/PiratesOfTheCaribbean.jpg", Name = "Pirates of the Caribbean: The Curse of the Black Pearl", ReleaseYear = 2003, RunTime = 143, Synopsis = "Blacksmith Will Turner teams up with eccentric pirate 'Captain' Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead." },
                        new { MovieID = 6, AverageRating = 0m, CategoryID = 3, ImgPath = "/Images/BlackPanther.jpg", Name = "Black Panther", ReleaseYear = 2018, RunTime = 133, Synopsis = "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past." },
                        new { MovieID = 7, AverageRating = 0m, CategoryID = 1, ImgPath = "/Images/AliceInWonderland.jpg", Name = "Alice in Wonderland", ReleaseYear = 1951, RunTime = 75, Synopsis = "Alice stumbles into the world of Wonderland. Will she get home? Not if the Queen of Hearts has her way." },
                        new { MovieID = 8, AverageRating = 0m, CategoryID = 3, ImgPath = "/Images/HomewardBound.jpg", Name = "Homeward Bound: The Incredible Journey", ReleaseYear = 1993, RunTime = 84, Synopsis = "Three pets escape from a California ranch to find their owners in San Francisco." },
                        new { MovieID = 9, AverageRating = 0m, CategoryID = 2, ImgPath = "/Images/Up.jpg", Name = "Up", ReleaseYear = 2009, RunTime = 96, Synopsis = "Seventy-eight year old Carl Fredricksen travels to Paradise Falls in his home equipped with balloons, inadvertently taking a young stowaway." },
                        new { MovieID = 10, AverageRating = 0m, CategoryID = 2, ImgPath = "/Images/TheIncredibles.jpg", Name = "The Incredibles", ReleaseYear = 2004, RunTime = 115, Synopsis = "A family of undercover superheroes, while trying to live the quiet suburban life, are forced into action to save the world." }
                    );
                });

            modelBuilder.Entity("DisneyMovieReviewSite.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieID");

                    b.Property<string>("ReviewContent");

                    b.Property<string>("UserName");

                    b.Property<int>("UserRating");

                    b.HasKey("ReviewID");

                    b.HasIndex("MovieID");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { ReviewID = 1, MovieID = 1, ReviewContent = "Ariel is a fiery, independent teenage mermaid who falls in love with a prince. She literally makes a deal with the devil to get her man. I love how sweet Ariel is with Eric, especially when she can't talk! Sebastian, Scuttle, and Flounder are all very funny, the animation, voice-overs and music are incredible! Who can resist the urge to sing and dance to 'Under The Sea'? A fun, enjoyable movie that the whole family will love and treasure.", UserName = "DisneyReviewer", UserRating = 5 },
                        new { ReviewID = 2, MovieID = 2, ReviewContent = "On paper, this marks one of Disney's trickiest films to date. A love story set in the middle east where the supporting characters include a monkey, flying carpet, and a genie (only one of which can talk) doesn't exactly sound like familiar territory . But the animators stay true to form and expand their horizons, especially Clements and Musker who were fresh off their success of The Little Mermaid. The exotic world that the animators portray is intriguing yet also friendly and familiar as they fill it with irresistible characters. Each personality is carefully crafted with several dimensions that make them even more real, especially Jasmine who surprisingly exhibits considerable strength and individuality, a trait that hasn't been prominent in Disney's female characters. And who can forget Genie, the result of the genius that is the late Robin Williams. Williams actually ad-libbed most of his lines and designers animated the characters based off his recordings after. And it is a wonderful performance that solidifies the movie as a classic.", UserName = "DisneyFanatic23", UserRating = 4 },
                        new { ReviewID = 3, MovieID = 3, ReviewContent = "Delightful animated feature from Walt Disney Pictures about a naive young lion cub destined for greatness.Born the son of a beloved and authoritative king he's groomed to be the next ruler of the kingdom, but along the way he encounters tragic detours at the hands of his villainous uncle and scheming hyena henchmen. Years later—as an adult—he decides to embrace his destiny and take his proper place in the Circle of Life. Warm, intelligent, laugh-out loud funny film is a triumph in every aspect; unforgettable songs, snappy dialogue, remarkable animation, and a stellar cast of voices make this a treat for all ages. A rousing adventure that you can enjoy again and again, and arguably one of the finest animated films ever made.", UserName = "DisneyLover", UserRating = 4 },
                        new { ReviewID = 4, MovieID = 4, ReviewContent = "Toy Story is a sheer delight to view on the screen.The characters are well done, the plot is exceptional, and the best thing of all, the film is entirely produced on the computer.The animation is extraordinary in it's ability to bring such great entertainment to the screen. The film also teaches some good lessons for the kids like friendship (mainly between Woody and Buzz Light-year). Spectacular entertainment all around and one of the best films Disney has come with.", UserName = "Mr. Whiplash", UserRating = 4 }
                    );
                });

            modelBuilder.Entity("DisneyMovieReviewSite.Models.Movie", b =>
                {
                    b.HasOne("DisneyMovieReviewSite.Models.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DisneyMovieReviewSite.Models.Review", b =>
                {
                    b.HasOne("DisneyMovieReviewSite.Models.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
