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

        public bool authorBook(int authorID)
        {
            bool authorBookExist = false;
            foreach (var book in dbContext.Books)
            {
              var bookWithAuthor = dbContext.Books.FirstOrDefault(a => a.AuthorID == authorID);
              if (bookWithAuthor != null)
              {
                 authorBookExist = true;
              }

            }
            return authorBookExist;
            
        }

        public void DeleteAuthor(Author author)
        {
            dbContext.Remove(author);
            dbContext.SaveChanges();
        }

        public bool DoesAuthorExist(Author author)
        {

            bool doesItExist = false;
            foreach (var existingAuthor in dbContext.Authors)
            {
                if (author.Name == existingAuthor.Name)
                {
                    doesItExist = true;
                }
            }
            return doesItExist;
        }

        public object GetAuthorByID(int authorID)
        {
            return dbContext.Authors.FirstOrDefault(i => i.ID == authorID);
        }

        public IList<Author> GetAuthors()
        {
            return dbContext.Authors.AsNoTracking().ToList();
        }

        public void UpdateAuthor(Author author)
        {
            dbContext.Entry(author).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
