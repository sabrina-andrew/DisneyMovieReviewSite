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
                ImgPath = "~/Images/TheLittleMermaid.jpg"
            } },

            {2, new Movie()
            {
                ID = 2,
                Name = "Aladdin",
                ImgPath = "~/Images/Aladdin.jpeg"
            } },

            {3, new Movie()
            {
                ID = 3,
                Name = "Lion King",
                ImgPath = "~/Images/LionKing.jpeg"
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
