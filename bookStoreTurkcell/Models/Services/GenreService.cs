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

        public IList<Genre> GetGenres()
        {
            return dbContext.Genres.AsNoTracking().ToList();
        }
    }
}
