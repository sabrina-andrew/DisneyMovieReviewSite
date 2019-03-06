using DisneyMovieReviewSite.Models;
using DisneyMovieReviewSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository categoryRepo;

        public CategoryController(ICategoryRepository categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
       
        public ViewResult Index()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = categoryRepo.GetByID(id);
            return View(model);
        }

   
    }
}
