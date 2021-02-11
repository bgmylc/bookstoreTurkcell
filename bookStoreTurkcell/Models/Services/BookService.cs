using bookStoreTurkcell.Data;
using bookStoreTurkcell.Models.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services
{
    public class BookService : IBookService
    {
        private bookStoreTurkcellDbContext dbContext;

        public BookService(bookStoreTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddBook(Book book)
        {
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
        }

        public List<Book> GetBooks()
        {
            return dbContext.Books.AsNoTracking().ToList();
            
        }

        public List<Book> GetBooksByGenreID(int genreID)
        {
            return dbContext.Books.AsNoTracking().Where(b => b.GenreID == genreID).ToList();
        }
    }
}
