using DisneyMovieReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
