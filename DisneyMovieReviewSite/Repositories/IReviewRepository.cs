using DisneyMovieReviewSite.Models;
using System.Collections.Generic;

namespace DisneyMovieReviewSite.Repositories
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAll();
        Review GetByID(int id);
        void Create(Review review);
        void Delete(Review review);
        void Edit(Review review);
    }
}
