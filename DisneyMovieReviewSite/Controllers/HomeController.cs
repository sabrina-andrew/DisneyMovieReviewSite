using Microsoft.AspNetCore.Mvc;

namespace DisneyMovieReviewSite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index(){
            return View();
        }
    }
}
