using DisneyMovieReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Repositories
{
    public class MovieRepository
    {

        MovieContext db;
        public MovieRepository(MovieContext db)
        {
            this.db = db;
            
        }

        public IEnumerable<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public Movie GetByID(int id)
        {
            return db.Movies.Single(movie=> movie.ID == id);
        }
    }
}
