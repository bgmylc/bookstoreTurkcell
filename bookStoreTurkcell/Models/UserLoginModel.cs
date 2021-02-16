using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş olamaz")]
        [Display(Name = "Kullanıcı Adı ")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre boş olamaz")]
        [DataType(DataType.Password)]
        [Display( Name = "Şifre")]
        public string Password { get; set; }
    }
}
