using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services
{
    public interface IGenreService
    {
        IList<Genre> GetGenres();
        void AddGenre(Genre genre);
        object GetGenreByID(int genreID);
        void UpdateGenre(Genre genre);
        void DeleteGenre(Genre genre);
        bool genreBook(int genreID);
        bool DoesGenreExist(Genre genre);
    }
}
