using DisneyMovieReviewSite.Models;
using DisneyMovieReviewSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Controllers
{
    public class ReviewController : Controller
    {
        ReviewRepository reviewRepo;
        public ReviewController(ReviewRepository reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            IEnumerable<Review> model = reviewRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetByID(id);
            return View(model);
        }
    }
}
