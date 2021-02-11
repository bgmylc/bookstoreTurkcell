using bookStoreTurkcell.Models;
using bookStoreTurkcell.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Controllers
{
    public class AuthorsController : Controller
    {
        private IAuthorService authorService;

        public AuthorsController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }
        public IActionResult Index()
        {
            var authors = authorService.GetAuthors(); //List authors
            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            if (ModelState.IsValid) //If there are no errors; add the author and return to the list
            {
                authorService.AddAuthor(author); 
                return RedirectToAction(nameof(Index));
            }
            
            return View(); //If there is an error open the same view again
        }
    }
}
