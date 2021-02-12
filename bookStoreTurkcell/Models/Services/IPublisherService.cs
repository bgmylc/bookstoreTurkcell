using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services
{
    public interface IPublisherService
    {
        IList<Publisher> GetPublishers();
        void AddPublisher(Publisher publisher);
        object GetPublisherByID(int pubID);
        void UpdatePublisher(Publisher publisher);
        void DeletePublisher(Publisher publisher);
        bool pubBook(int pubID);
        bool DoesPubExist(Publisher publisher);
    }
}
