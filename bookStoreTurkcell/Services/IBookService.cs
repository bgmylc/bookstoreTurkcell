using bookStoreTurkcell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
        List<Book> GetBooksByGenreID(int genreID);
        List<Book> GetBooksByAuthorID(int authorID);
        List<Book> GetBooksByPubID(int pubID);

        void AddBook(Book book);
        Book GetBookDetailsByID(int? bookID);
        int UpdateBook(Book book);
        void DeleteBook(Book book);
        bool DoesBookExist(Book book);
        Book GetBookByID(int bookID);
    }
}
