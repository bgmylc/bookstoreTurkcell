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
    public class AuthorsController : Controller
    {
        private IAuthorService authorService;
        private IBookService bookService;

        public AuthorsController(IAuthorService authorService, IBookService bookService)
        {
            this.authorService = authorService;
            this.bookService = bookService;
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

            if (authorService.DoesAuthorExist(author))
            {
                ViewBag.Message = 0;
                return View(author);

            }
            else if (ModelState.IsValid) //If there are no errors; add the author and return to the list
            {
                authorService.AddAuthor(author); 
                return RedirectToAction(nameof(Index));
            }
            
            return View(); //If there is an error open the same view again
        }


        public IActionResult Edit(int authorID)
        {
            var author = authorService.GetAuthorByID(authorID);

            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            if (ModelState.IsValid)
            {

                authorService.UpdateAuthor(author);
                return RedirectToAction(nameof(Index));
            }

            return View(author);
        }

        public IActionResult Delete(int authorID)
        {
            var author = authorService.GetAuthorByID(authorID);

            if (author == null)
            {
                return NotFound();
            }
            
            return View(author);
        }

        [HttpPost]
        public IActionResult Delete(Author author)
        {
            if (authorService.authorBook(author.ID))
            {
                ViewBag.Message = 0;
                return View(author);
            }
            
            authorService.DeleteAuthor(author);
            return RedirectToAction(nameof(Index));

        }

    

        public IActionResult Details(int authorID)
        {
            var author = authorService.GetAuthorByID(authorID);

            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }


    }
}
