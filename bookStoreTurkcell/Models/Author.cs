using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models
{
    public class Author
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Lütfen yazar ismini giriniz!")]
        [Display(Name = "Yazarın Adı")]
        public string Name { get; set; }

        [Display(Name = "Yazarın Özgeçmişi")]
        public string Bio { get; set; }

        [Display(Name = "Yazar Resmi URL'si")]
        public string ImageUrl { get; set; }

        public IList<Book> Books { get; set; }
    }
}
