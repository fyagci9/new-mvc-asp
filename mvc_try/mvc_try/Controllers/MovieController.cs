using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvc_try.Data;
using mvc_try.Models;
using System.Linq;

namespace mvc_try.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            return View();

        }
        
        public IActionResult List(int? id, string q)
        {


            var movies = MovieRepository.Movies;

            if (id != null)
            {
                movies = movies.Where(m => m.GenreId == id).ToList();
            }

            //kelimeye göre film  arama

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i=>
                i.Title.ToLower().Contains(q.ToLower()) ||
                i.Description.ToLower().Contains(q.ToLower()) ).ToList();
            }
            var model = new MoviesVievModel()
            {
                Movies = movies
            };


            return View("Movies", model);

        }

        // https://localhost:44318/movie/details
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Add(m);
                TempData["Message"] = $"{m.Title} isimli film silindi";
                return RedirectToAction("List");
            }
            
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();

           
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(MovieRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Edit(m);
                return RedirectToAction("Details", "Movie", new { @id = m.MovieId });

            }
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");

            return View(m);
        }

        [HttpPost]
        public IActionResult Delete(int MovieId, string Title)
        {

            MovieRepository.Delete(MovieId);
            TempData["Message"] = $"{Title} isimli film silindi.";
            return RedirectToAction("List");
        }
    }
}
