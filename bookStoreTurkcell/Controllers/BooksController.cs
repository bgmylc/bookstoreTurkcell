using bookStoreTurkcell.Models;
using bookStoreTurkcell.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BooksController : Controller
    {
        private IBookService bookService;
        private IGenreService genreService;
        private IAuthorService authorService;
        private IPublisherService publisherService;

        public BooksController(IBookService bookService, IGenreService genreService, IAuthorService authorService, IPublisherService publisherService)
        {
            this.bookService = bookService;
            this.genreService = genreService;
            this.authorService = authorService;
            this.publisherService = publisherService;
        }
        public IActionResult Index()
        {
            var books = bookService.GetBooks(); //List books
            return View(books);
        
        }

        public IActionResult Create()
        {
            //We want to show genres, authors and publisher as dropdown menus
            //In order to do that we need to show their names to the user but keep their ID's for recognition
            //We also need them to be IEnumerable SelectListItem for asp-item to show them
            //To reach them easily we turn these processes into new methods
            
            List<SelectListItem> selectListGenres = getGenresToSelect();
            ViewBag.GenreItems = selectListGenres;

            List<SelectListItem> selectListAuthors = getAuthorsToSelect();
            ViewBag.AuthorItems = selectListAuthors;
            
            List<SelectListItem> selectListItems = getPublisherToSelect();
            ViewBag.PubItems = selectListItems;

            return View();
        }

        private List<SelectListItem> getPublisherToSelect()
        {
            var pubList = publisherService.GetPublishers();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            pubList.ToList().ForEach(p => selectListItems.Add(new SelectListItem
            {
                Text = p.Name,
                Value = p.ID.ToString()
            }));
            return selectListItems;
        }

        private List<SelectListItem> getAuthorsToSelect()
        {
            var authorList = authorService.GetAuthors();
            List<SelectListItem> selectListAuthors = new List<SelectListItem>();
            authorList.ToList().ForEach(a => selectListAuthors.Add(new SelectListItem
            {
                Text = a.Name,
                Value = a.ID.ToString()
            }));
            return selectListAuthors;
        }

        private List<SelectListItem> getGenresToSelect()
        {
            var genreList = genreService.GetGenres();
            List<SelectListItem> selectListGenres = new List<SelectListItem>();
            genreList.ToList().ForEach(g => selectListGenres.Add(new SelectListItem
            {
                Text = g.Name,
                Value = g.ID.ToString()
            }));
            return selectListGenres;
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (bookService.DoesBookExist(book))
            {
                ViewBag.Message = 0;
                return View();

            }
            else if (ModelState.IsValid) //If there are no errors; add the book and return to the list
            {
                bookService.AddBook(book);
                return RedirectToAction(nameof(Index));
            }
            
            List<SelectListItem> selectListGenres = getGenresToSelect();
            ViewBag.GenreItems = selectListGenres;

            List<SelectListItem> selectListAuthors = getAuthorsToSelect();
            ViewBag.AuthorItems = selectListAuthors;

            List<SelectListItem> selectListItems = getPublisherToSelect();
            ViewBag.PubItems = selectListItems;

            return View(); //If there is an error open the same view again, also show the dropdown items again
        }

        public IActionResult Edit(int bookID)
        {
            var book = bookService.GetBookDetailsByID(bookID);
           
            if (book == null)
            {
                return NotFound();
            }

            List<SelectListItem> selectListGenres = getGenresToSelect();
            ViewBag.GenreItems = selectListGenres;

            List<SelectListItem> selectListAuthors = getAuthorsToSelect();
            ViewBag.AuthorItems = selectListAuthors;

            List<SelectListItem> selectListItems = getPublisherToSelect();
            ViewBag.PubItems = selectListItems;

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
              
                int editedRowsCount = bookService.UpdateBook(book);
                return RedirectToAction(nameof(Index));
            }

            List<SelectListItem> selectListGenres = getGenresToSelect();
            ViewBag.GenreItems = selectListGenres;

            List<SelectListItem> selectListAuthors = getAuthorsToSelect();
            ViewBag.AuthorItems = selectListAuthors;

            List<SelectListItem> selectListItems = getPublisherToSelect();
            ViewBag.PubItems = selectListItems;

            return View(book);
        }

        public IActionResult Delete(int bookID)
        {
            var book = bookService.GetBookDetailsByID(bookID);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
           
                bookService.DeleteBook(book);
                return RedirectToAction(nameof(Index));
            
        }


        public IActionResult Details(int bookID)
        {
            var book = bookService.GetBookDetailsByID(bookID);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

    }
}
