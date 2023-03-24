using Microsoft.AspNetCore.Mvc;

namespace MVCMovies.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WelcomeMF(string name, int id)
        {
            ViewData["Title"] = "Welcome MF";
            
            return View();
            
        }
    }
    // => $"Hello, Welcome {name}! You're MotherFucker number {number}";//parameters to html on the address bar is, first "?" and the others are "&".
}
