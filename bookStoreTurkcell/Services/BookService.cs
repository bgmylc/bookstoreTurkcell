using bookStoreTurkcell.Data;
using bookStoreTurkcell.Models;
using bookStoreTurkcell.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Services
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

        public void DeleteBook(Book book)
        {
            dbContext.Remove(book);
            dbContext.SaveChanges();
        }

        public bool DoesBookExist(Book book)
        {
            bool doesItExist = false;

            var existingBook = dbContext.Books.FirstOrDefault(b => b.ISBN == book.ISBN);
            doesItExist = existingBook == null ? false : true;

            return doesItExist;
        }

        public Book GetBookByID(int bookID)
        {
            return dbContext.Books.Find(bookID);
        }

        public Book GetBookDetailsByID(int? bookID)
        {
            return dbContext.Books.Include(a => a.Author)
                                  .Include(p => p.Publisher)
                                  .Include(g => g.Genre)
                                  .FirstOrDefault(i => i.ID == bookID);
        }

        public List<Book> GetBooks()
        {
            return dbContext.Books.Include(a => a.Author)
                                  .Include(p => p.Publisher)
                                  .Include(g => g.Genre)
                                  .AsNoTracking().ToList();
            
        }

        public List<Book> GetBooksByAuthorID(int authorID)
        {
            return dbContext.Books.Include(a => a.Author)
                                  .Include(p => p.Publisher)
                                  .Include(g => g.Genre)
                                  .AsNoTracking().Where(b => b.AuthorID == authorID).ToList();
        }

        public List<Book> GetBooksByGenreID(int genreID)
        {
            return dbContext.Books.Include(a => a.Author)
                                  .Include(p => p.Publisher)
                                  .Include(g => g.Genre)
                                  .AsNoTracking().Where(b => b.GenreID == genreID).ToList();
        }

        public List<Book> GetBooksByPubID(int pubID)
        {
            return dbContext.Books.Include(a => a.Author)
                                  .Include(p => p.Publisher)
                                  .Include(g => g.Genre)
                                  .AsNoTracking().Where(b => b.PublisherID == pubID).ToList();
        }

        public int UpdateBook(Book book)
        {
           dbContext.Entry(book).State = EntityState.Modified;
           return dbContext.SaveChanges();

        }

        
        


    }
}
