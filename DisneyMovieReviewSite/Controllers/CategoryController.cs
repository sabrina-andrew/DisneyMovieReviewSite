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
        CategoryRepository categoryRepo;

        public CategoryController(CategoryRepository categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult Category()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }
    }
}
