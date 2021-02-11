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
    }
}
