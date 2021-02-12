using bookStoreTurkcell.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services
{
    public class GenreService : IGenreService
    {
        private bookStoreTurkcellDbContext dbContext;

        public GenreService(bookStoreTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddGenre(Genre genre)
        {
            dbContext.Genres.Add(genre);
            dbContext.SaveChanges();
        }

        public void DeleteGenre(Genre genre)
        {
            dbContext.Remove(genre);
            dbContext.SaveChanges();
        }

        public bool DoesGenreExist(Genre genre)
        {
            bool doesItExist = false;
            foreach (var gen in dbContext.Genres)
            {
                if (genre.Name == gen.Name)
                {
                    doesItExist = true;
                }
            }
            return doesItExist;
        }

        public bool genreBook(int genreID)
        {
            bool genreBookExist = false;
            foreach (var book in dbContext.Books)
            {
                var bookGenre = dbContext.Books.FirstOrDefault(a => a.GenreID == genreID);
                if (bookGenre != null)
                {
                    genreBookExist = true;
                }

            }
            return genreBookExist;
        }

        public object GetGenreByID(int genreID)
        {
            return dbContext.Genres.FirstOrDefault(i => i.ID == genreID);
        }

        public IList<Genre> GetGenres()
        {
            return dbContext.Genres.AsNoTracking().ToList();
        }

        public void UpdateGenre(Genre genre)
        {
            dbContext.Entry(genre).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
