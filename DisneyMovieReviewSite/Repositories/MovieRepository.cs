using DisneyMovieReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DisneyMovieReviewSite.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        MovieContext db;
        public MovieRepository(MovieContext db)
        {
            this.db = db;
        }


        public Movie GetByID(int id)
        {
            return db.Movies.Single(movie => movie.MovieID == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public void Create(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }
        public void Delete(Movie movie)
        {
            db.Movies.Remove(movie);
            db.SaveChanges();
        }

        public void Edit(Movie movie)
        {
            db.Update(movie);
            db.SaveChanges();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
