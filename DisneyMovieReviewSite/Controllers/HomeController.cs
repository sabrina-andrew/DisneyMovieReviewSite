using DisneyMovieReviewSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Controllers
{
    public class HomeController : Controller
    {
        MovieRepository movieRepo;

        public HomeController()
        {
            movieRepo = new MovieRepository();
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Details(int id)
        {
            var model = movieRepo.GetByID(id);
            return View();
        }


    }
}
