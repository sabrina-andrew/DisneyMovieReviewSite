using DisneyMovieReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        MovieContext db;
        public CategoryRepository(MovieContext db)
        {
            this.db = db; 
        }
        public Category GetCategory(int id)
        {
            return db.Categories.Single(category => category.CategoryID == id);
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetByID(int id)
        {
            return db.Categories.Single(category => category.CategoryID == id);
        }
    }
}
