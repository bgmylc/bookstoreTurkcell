using bookStoreTurkcell.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models.Services
{
    public class PublisherService : IPublisherService
    {
        private bookStoreTurkcellDbContext dbContext;

        public PublisherService(bookStoreTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddPublisher(Publisher publisher)
        {
            dbContext.Publishers.Add(publisher);
            dbContext.SaveChanges();
        }

        public IList<Publisher> GetPublishers()
        {
            return dbContext.Publishers.AsNoTracking().ToList();
            
        }
    }
}
