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

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetByID(id);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("Index");
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
            return RedirectToAction("Details/" + review.ReviewID);
        }
    }
}
