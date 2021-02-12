using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services
{
    public interface IAuthorService
    {
     
        IList<Author> GetAuthors();
        void AddAuthor(Author author);
        object GetAuthorByID(int authorID);
        void UpdateAuthor(Author author);
        void DeleteAuthor(Author author);
        bool authorBook(int authorID);
        bool DoesAuthorExist(Author author);
    }
}
