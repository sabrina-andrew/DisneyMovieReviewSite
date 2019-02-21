using DisneyMovieReviewSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository movieRepo;

        public MovieController()
        {
            movieRepo = new MovieRepository();
        }

        public ViewResult Index()
        {
            var model = movieRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = movieRepo.GetByID(id);
            return View(model);
        }


    }
}
