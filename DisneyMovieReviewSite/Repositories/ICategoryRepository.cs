using DisneyMovieReviewSite.Models;
using System.Collections.Generic;

namespace DisneyMovieReviewSite.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category GetByID(int id);
    }
}
