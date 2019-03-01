using DisneyMovieReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Repositories
{
    public class ReviewRepository
    {
        MovieContext db;
        public ReviewRepository(MovieContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Reviews.Count();
        }

        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }
        public Review GetByID(int id)
        {
            return db.Reviews.Single(review => review.ReviewID == id);
        }
        public void Delete(Review review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public void Edit(Review review)
        {
            db.Reviews.Update(review);
            db.SaveChanges();
        }
    }
}
