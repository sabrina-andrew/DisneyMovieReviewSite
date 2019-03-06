using DisneyMovieReviewSite.Models;
using DisneyMovieReviewSite.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace DisneyMovieReviewSite.Controllers
{
    public class MovieController : Controller
    {
        IMovieRepository movieRepo;

        public MovieController(IMovieRepository movieRepo)
        {
            this.movieRepo = movieRepo;
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            movieRepo.Create(movie);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = movieRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Movie movie)
        {
           
            movieRepo.Delete(movie);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = movieRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            movieRepo.Edit(movie);
            return RedirectToAction("Details/" + movie.MovieID);
        }
    }
}

