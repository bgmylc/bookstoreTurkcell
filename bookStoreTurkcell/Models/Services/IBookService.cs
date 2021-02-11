using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
        List<Book> GetBooksByGenreID(int genreID);
        void AddBook(Book book);
    }
}
