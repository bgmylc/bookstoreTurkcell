﻿using bookStoreTurkcell.Data;
using bookStoreTurkcell.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Services
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

        public void DeletePublisher(Publisher publisher)
        {
            dbContext.Remove(publisher);
            dbContext.SaveChanges();
        }

        public bool DoesPubExist(Publisher publisher)
        {
            bool doesItExist = false;

            var existingPub = dbContext.Publishers.FirstOrDefault(p => p.Name == publisher.Name);
            doesItExist = existingPub == null ? false : true;

            return doesItExist;
        }

        public object GetPublisherByID(int pubID)
        {
            return dbContext.Publishers.FirstOrDefault(i => i.ID == pubID);
        }

        public IList<Publisher> GetPublishers()
        {
            return dbContext.Publishers.AsNoTracking().ToList();
            
        }

        public bool pubBook(int pubID)
        {
            bool pubBookExist = false;
            foreach (var book in dbContext.Books)
            {
                var bookPub = dbContext.Books.FirstOrDefault(a => a.PublisherID == pubID);
                if (bookPub != null)
                {
                    pubBookExist = true;
                }

            }
            return pubBookExist;
        }

        public void UpdatePublisher(Publisher publisher)
        {
            dbContext.Entry(publisher).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
