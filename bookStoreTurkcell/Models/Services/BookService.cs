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


        public bool BookExist(int bookID)
        {
            return dbContext.Books.Any(b => b.ID == bookID);
        }

        public void DeleteBook(Book book)
        {
            dbContext.Remove(book);
            dbContext.SaveChanges();
        }

        public bool DoesBookExist(Book book)
        {
            bool doesItExist = false;
            foreach (var existingBook in dbContext.Books)
            {
                if (book.ISBN == existingBook.ISBN)
                {
                    doesItExist = true;
                }
            }
            return doesItExist;
        }

        public object GetBookByID(int? bookID)
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

        public List<Book> GetBooksByGenreID(int genreID)
        {
            return dbContext.Books.Include(a => a.Author)
                                  .Include(p => p.Publisher)
                                  .Include(g => g.Genre)
                                  .AsNoTracking().Where(b => b.GenreID == genreID).ToList();
        }

        public int UpdateBook(Book book)
        {
           dbContext.Entry(book).State = EntityState.Modified;
           return dbContext.SaveChanges();

        }

        
        


    }
}
