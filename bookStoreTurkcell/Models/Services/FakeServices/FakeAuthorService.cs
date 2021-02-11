using bookStoreTurkcell.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services.FakeServices
{
    public class FakeAuthorService : IAuthorService
    {
        public void AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public IList<Author> GetAuthors()
        {
            return new List<Author>
            {

                new Author{ID=1, Name="A.M. Celal Şengör", Bio="Bilgili Biri", ImageUrl="https://cdn.kidega.com/author/large/celal-sengor-profil-0y.jpg"},
                new Author{ID=2, Name="Adrian Tchaikovsky", Bio="Değişik karakter", ImageUrl="https://images.gr-assets.com/authors/1282303363p5/1445909.jpg"},
                new Author{ID=3, Name="Agatha Christie", Bio="Efsane", ImageUrl="https://upload.wikimedia.org/wikipedia/commons/c/cf/Agatha_Christie.png"},
                new Author{ID=4, Name="Ahmet Hamdi Tanpınar", Bio="Çok iyi", ImageUrl="https://cdn.kidega.com/author/large/ahmet-hamdi-tanpinar-profil-ov.jpg"},
                new Author{ID=5, Name="Alan Moore", Bio="Çılgın", ImageUrl="https://m.media-amazon.com/images/M/MV5BZGRhNmE0NWMtNzBkNS00MDEzLWIxNjMtNWYwYzMyMWFmMGIyXkEyXkFqcGdeQXVyMTExNDQ2MTI@._V1_.jpg"},
                new Author{ID=6, Name="Albert Camus", Bio="Kötümser", ImageUrl="https://cdn.kidega.com/author/large/albert-camus-profil-pJ.jpg"},
                new Author{ID=7, Name="Aldous Huxley", Bio="Sıkıntılı", ImageUrl="https://cdn.kidega.com/author/large/aldous-huxley-profil-1y.jpg"}

            };
        }
    }
}
