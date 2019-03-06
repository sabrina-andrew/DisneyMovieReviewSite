using DisneyMovieReviewSite.Models;
using DisneyMovieReviewSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace DisneyMovieReviewSite.Controllers
{
    public class ReviewController : Controller
    {
        IReviewRepository reviewRepo;
        public ReviewController(IReviewRepository reviewRepo)
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

        [HttpGet]
        public ViewResult Create(int id)
        {
            var newReview = new Review()
            {
                MovieID = id
            };

            return View(newReview);
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("../Movie/Details/" + review.MovieID);
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("../Movie/Index");
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = reviewRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Review review)
        {
            reviewRepo.Edit(review);
            return RedirectToAction("../Movie/Details/" + review.MovieID);
        }
    }
}
