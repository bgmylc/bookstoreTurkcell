using bookStoreTurkcell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Services
{
     public interface IUserService
    {
        User ValidUser(string username, string password);
        string userRole(int userID);
        User GetUserByID(int userID);
        string GetAddressByUserID(int userID);
    }

}
