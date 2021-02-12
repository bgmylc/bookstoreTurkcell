using bookStoreTurkcell.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services.FakeServices
{
    public class FakePublisherService : IPublisherService
    {
        public void AddPublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public void DeletePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public bool DoesPubExist(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public object GetPublisherByID(int pubID)
        {
            throw new NotImplementedException();
        }

        public IList<Publisher> GetPublishers()
        {
            return new List<Publisher>
            {

                new Publisher{ID=91, Name="Türkiye İş Bankası Kültür Yayınları", Description="Sıkıntılı"},
                new Publisher{ID=27, Name="Eksik Parça", Description="Kötümser"},
                new Publisher{ID=5, Name="Altın Kitaplar", Description="Çılgın"},
                new Publisher{ID=21, Name="Dergah Yayınları", Description="Sıkıntılı"},
                new Publisher{ID=16, Name="Can Yayınları", Description="Değişik"},
                new Publisher{ID=47, Name="İthaki Yayınları", Description="Çılgın"}
            };
        }

        public bool pubBook(int pubID)
        {
            throw new NotImplementedException();
        }

        public void UpdatePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }
    }
}
