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

        public int Count()
        {
            return db.Movies.Count();
        }

        public void Create(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        } 
        public Movie GetByID(int id)
        {
            return db.Movies.Single(movie=> movie.ID == id);
        }
        public void Delete(Movie movie)
        {
            db.Movies.Remove(movie);
            db.SaveChanges();
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public IEnumerable<Movie> GetAll()
        {
            return db.Movies.ToList();
        }
    }
}
