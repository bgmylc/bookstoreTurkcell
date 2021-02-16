using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email{ get ; set; }
        public string DeliveryAdress { get; set; }
        public string InvoiceAdress { get; set; }
        public int UserRoleID { get; set; }
        public UserRole UserRole { get; set; }
    }
}
