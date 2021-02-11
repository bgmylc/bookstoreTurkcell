using bookStoreTurkcell.Models;
using bookStoreTurkcell.Models.Services;
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
        public HomeController(ILogger<HomeController> logger, IBookService bookService)
        {
            _logger = logger;
            this.bookService = bookService;
        }


        public IActionResult Index(int page=1, int genreID = 0) //default page number is 1
        {
            var books = genreID == 0 ? bookService.GetBooks() : bookService.GetBooksByGenreID(genreID);
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
