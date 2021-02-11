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
    }
}
