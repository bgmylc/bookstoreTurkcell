using bookStoreTurkcell.Data;
using bookStoreTurkcell.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Services
{
    public class UserService : IUserService
    {
        private bookStoreTurkcellDbContext dbContext;

        public UserService(bookStoreTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public string GetAddressByUserID(int userID)
        {
            var user = dbContext.Users.Find(userID);
            return user.DeliveryAdress;
        }

        public User GetUserByID(int userID)
        {
            return dbContext.Users.Include(r => r.UserRole)
                                    .FirstOrDefault(i => i.ID == userID);

        }

        public string userRole(int userID)
        {
            var user = GetUserByID(userID);
            return user.UserRole.Name;
        }

        public User ValidUser(string username, string password)
        {
            return dbContext.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
