using bookStoreTurkcell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Services.FakeServices
{
    public class FakeUserService : IUserService
    {
        private List<User> users = new List<User>
        {
            new User{Name = "Segum", Surname="Yolcu", UserName="segum123", Email="segum@segum.com", Password="flokifloki23", DeliveryAdress="Ankara", InvoiceAdress = "Ankara", PhoneNumber="1234567899", UserRole= new UserRole{Name="StandardUser" } },
            new User{Name = "Floki",Surname="Yolcu", UserName="floskos123", Email="floki@segum.com", Password="segumfloki23", DeliveryAdress="Ankara", InvoiceAdress = "Ankara", PhoneNumber="9987654321" , UserRole = new UserRole{Name = "Admin" } }
        };

        public string GetAddressByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public User GetUserByID(int userID)
        {
            throw new NotImplementedException();
        }

     
        public string userRole(int userID)
        {
            throw new NotImplementedException();
        }

        public User ValidUser(string username, string password)
        {
            return users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
