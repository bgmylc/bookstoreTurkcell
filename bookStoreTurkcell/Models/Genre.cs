using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models
{
    public class Genre
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen tür ismini giriniz!")]
        [Display(Name = "Tür İsmi")]
        public string Name { get; set; }
      
        public IList<Book> Books { get; set; }
    }
}
