using bookStoreTurkcell.Models;
using bookStoreTurkcell.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Controllers
{
    public class GenresController : Controller
    {
        private IGenreService genreService;

        public GenresController(IGenreService genreService)
        {
            this.genreService = genreService;
        }
        public IActionResult Index()
        {
            var genres = genreService.GetGenres(); //List the genres
            return View(genres);
        }

        public IActionResult Create()
        {
            return View();       
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (ModelState.IsValid) //If there are no errors; add the genre and return to the list
            {
                genreService.AddGenre(genre);
                return RedirectToAction(nameof(Index));
            }

            return View(); //If there is an error open the same view again
        }
    }
}
