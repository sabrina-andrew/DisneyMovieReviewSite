using DisneyMovieReviewSite.Models;
using System.Collections.Generic;

namespace DisneyMovieReviewSite.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        Movie GetByID(int id);
        void Create(Movie movie);
        void Delete(Movie movie);
        void Edit(Movie movie);
    }
}
