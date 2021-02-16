using bookStoreTurkcell.Models;
using bookStoreTurkcell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Services.FakeServices
{
    public class FakeGenreService : IGenreService
    {
        public void AddGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public void DeleteGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public bool DoesGenreExist(Genre genre)
        {
            throw new NotImplementedException();
        }

        public bool genreBook(int genreID)
        {
            throw new NotImplementedException();
        }

        public object GetGenreByID(int genreID)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetGenres()
        {
           return new List<Genre>
           {
           new Genre { ID = 1, Name = "Amerikan Edebiyatı"},
           new Genre { ID = 2, Name = "Bilim" },
           new Genre { ID = 3, Name = "Bilimkurgu"},
           new Genre { ID = 4, Name = "Biyografi"},
           new Genre { ID = 5, Name = "Çağdaş"},
           new Genre { ID = 6, Name = "Çizgi Roman"},
           new Genre { ID = 7, Name = "Çocuk & Gençlik" },
           new Genre { ID = 8, Name = "Dünya Edebiyatı"},
           new Genre { ID = 9, Name = "Fantastik" },
           new Genre { ID = 10, Name = "Felsefe" },
           new Genre { ID = 11, Name = "Fransız Edebiyatı" },
           new Genre { ID = 12, Name = "Genç Yetişkin" },
           new Genre { ID = 13, Name = "Gizem - Gerilim" },
           new Genre { ID = 14, Name = "Gotik Edebiyat" },
           new Genre { ID = 15, Name = "İngiliz Edebiyatı" },
           new Genre { ID = 16, Name = "Klasik Yunan" },
           new Genre { ID = 17, Name = "Korku - Gerilim" },
           new Genre { ID = 18, Name = "Kurgudışı" },
           new Genre { ID = 19, Name = "Kültür - Sanat" },
           new Genre { ID = 20, Name = "Latin Edebiyatı" },
           new Genre { ID = 21, Name = "Mitoloji" },
           new Genre { ID = 22, Name = "Modern Klasikler" },
           new Genre { ID = 23, Name = "Polisiye" },
           new Genre { ID = 24, Name = "Popüler Bilim" },
           new Genre { ID = 25, Name = "Romantik" },
           new Genre { ID = 26, Name = "Rus Edebiyatı" },
           new Genre { ID = 27, Name = "Sosyoloji" },
           new Genre { ID = 28, Name = "Türk Edebiyatı" }
           
           };


        }

        public void UpdateGenre(Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}
