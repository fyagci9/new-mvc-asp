using Microsoft.AspNetCore.Mvc;
using mvc_try.Data;
using mvc_try.Models;
using System.Collections.Generic;

namespace mvc_try.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                PopularMovies = MovieRepository.Movies
            };
           
            return View(model);
        }
        public IActionResult About()
       
        {
            

            return View();
        }
    }
}
