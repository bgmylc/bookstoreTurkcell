using bookStoreTurkcell.Models;
using bookStoreTurkcell.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Controllers
{
    [Authorize(Roles = "Admin")]
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
            if (genreService.DoesGenreExist(genre))
            {
                ViewBag.Message = 0;
                return View();
            }
            else if (ModelState.IsValid) //If there are no errors; add the genre and return to the list
            {
                genreService.AddGenre(genre);
                return RedirectToAction(nameof(Index));
            }

            return View(); //If there is an error open the same view again
        }

        public IActionResult Edit(int genreID)
        {
            var genre = genreService.GetGenreByID(genreID);

            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        [HttpPost]
        public IActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {

                genreService.UpdateGenre(genre);
                return RedirectToAction(nameof(Index));
            }

            return View(genre);
        }

        public IActionResult Delete(int genreID)
        {
            var genre = genreService.GetGenreByID(genreID);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        [HttpPost]
        public IActionResult Delete(Genre genre)
        {
            if (genreService.genreBook(genre.ID))
            {
                ViewBag.Message = 0;
                return View(genre);
            }

            genreService.DeleteGenre(genre);
            return RedirectToAction(nameof(Index));

        }
    }
}
