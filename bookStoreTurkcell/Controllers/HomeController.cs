using bookStoreTurkcell.Models;
using bookStoreTurkcell.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBookService bookService;
        private IAuthorService authorService;
        private IPublisherService publisherService;

        public HomeController(ILogger<HomeController> logger, IBookService bookService, IAuthorService authorService, IPublisherService publisherService)
        {
            _logger = logger;
            this.bookService = bookService;
            this.authorService = authorService;
            this.publisherService = publisherService;
        }


        public IActionResult Index(int page=1, int genreID = 0, int authorID = 0, int pubID = 0) //default page number is 1
        {
            var books = bookService.GetBooks();

            if (genreID == 0 && authorID == 0 && pubID ==0)
            {
                books = bookService.GetBooks();

            }
            else if (authorID != 0)
            {
                books = bookService.GetBooksByAuthorID(authorID);
            }
            else if (pubID != 0)
            {
               books = bookService.GetBooksByPubID(pubID);
            }
            else if (genreID != 0)
            {
                books = bookService.GetBooksByGenreID(genreID);
            }
            ViewBag.AuthorID = authorID;
            ViewBag.PubID = pubID;
            ViewBag.GenreID = genreID;

            var pageSize = 12; //Number of books per page
            var pagingBooks = books.OrderByDescending(b => b.PublishDate) //Order the books by their publish date (Newest to oldest)
                                   .Skip((page-1)*pageSize) //Skip the book groups of the previous pages
                                   .Take(pageSize); //Take 12 books for the current page

            var totalBooks = books.Count;
            var totalPages = Math.Ceiling((decimal)totalBooks / pageSize); //Total number of pages rounded up
            ViewBag.TotalPages = totalPages;
           
            return View(pagingBooks);
        }
        public IActionResult Author(int page = 1, int authorID = 0)
        {
            var authors = authorService.GetAuthors();
            ViewBag.AuthorID = authorID;

            var pageSize = 12; 
            var pagingAuthors = authors.OrderBy(b => b.Name) 
                                   .Skip((page - 1) * pageSize) 
                                   .Take(pageSize); 

            var totalAuthors = authors.Count;
            var totalPages = Math.Ceiling((decimal)totalAuthors / pageSize); 
            ViewBag.TotalPages = totalPages;

            return View(pagingAuthors);
        }

        public IActionResult Publisher(int page = 1, int pubID = 0) //default page number is 1
        {
            var pubs = publisherService.GetPublishers();
            ViewBag.PubID = pubID;

            var pageSize = 12; //Number of books per page
            var pagingPubs = pubs.OrderBy(b => b.Name) //Order the books by their publish date (Newest to oldest)
                                   .Skip((page - 1) * pageSize) //Skip the book groups of the previous pages
                                   .Take(pageSize); //Take 12 books for the current page

            var totalPublishers = pubs.Count;
            var totalPages = Math.Ceiling((decimal)totalPublishers / pageSize); //Total number of pages rounded up
            ViewBag.TotalPages = totalPages;

            return View(pagingPubs);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
