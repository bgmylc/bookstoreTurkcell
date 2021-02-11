using bookStoreTurkcell.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services
{
    public class AuthorService : IAuthorService
    {
        private bookStoreTurkcellDbContext dbContext;

        public AuthorService(bookStoreTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddAuthor(Author author)
        {
            dbContext.Authors.Add(author);
            dbContext.SaveChanges();
        }

        public IList<Author> GetAuthors()
        {
            return dbContext.Authors.AsNoTracking().ToList();
        }
    }
}
