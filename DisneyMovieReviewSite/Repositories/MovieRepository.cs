using DisneyMovieReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Repositories
{
    public class MovieRepository
    {
        Dictionary<int, Movie> movies = new Dictionary<int, Movie>()
        {
            {1, new Movie()
            {
                ID = 1,
                Name = "The Little Mermaid",
                ImgPath = "/Images/TheLittleMermaid.jpg",
                Synopsis = "A mermaid named Ariel falls in love with a human prince, and must find her destiny with the help of family and friends.",
                ReleaseYear = 1989,
                Category = "Animation",
                RunTime = 85,
                Rating = 5.0,

            } },

            {2, new Movie()
            {
                ID = 2,
                Name = "Aladdin",
                ImgPath = "/Images/Aladdin.jpeg",
                Synopsis = "Aladdin, a streetwise nobody from the land of Agrabah, finds a magical lamp that will allow his every wish to be granted. He must find a way to stop the evil Jafar and win the love of Princess Jasmine.",
                ReleaseYear = 1992,
                Category  = "Animation",
                RunTime = 91,
                Rating = 4.0,
            } },

            {3, new Movie()
            {
                ID = 3,
                Name = "Lion King",
                ImgPath = "/Images/LionKing.jpeg",
                Synopsis = "Simba is a young lion set to inherit the kingdom from his father, Mufasa. When Simba's evil uncle Scar betrays him, Simba escapes into exile, and must find the courage to reclaim his birthright.",
                ReleaseYear = 1994,
                Category = "Animation",
                RunTime = 89,
                Rating = 4.0,
            } },

            {4, new Movie()
            {
                ID = 4,
                Name = "Lion King",
                ImgPath = "/Images/LionKing.jpeg",
                Synopsis = "Simba is a young lion set to inherit the kingdom from his father, Mufasa. When Simba's evil uncle Scar betrays him, Simba escapes into exile, and must find the courage to reclaim his birthright.",
                ReleaseYear = 1994,
                Category = "Animation",
                RunTime = 89,
                Rating = 4.0,
            } }
        };

        public IEnumerable<Movie> GetAll()
        {
            return movies.Values.ToList();
        }

        public Movie GetByID(int id)
        {
            return movies[id];
        }
    }
}
