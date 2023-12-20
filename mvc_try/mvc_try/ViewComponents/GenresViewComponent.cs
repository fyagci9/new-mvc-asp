using Microsoft.AspNetCore.Mvc;
using mvc_try.Data;
using mvc_try.Models;
using System;
using System.Collections.Generic;

namespace mvc_try.ViewComponents
{
    public class GenresViewComponent: ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(GenreRepository.Genres);
        }

       
    }
}
