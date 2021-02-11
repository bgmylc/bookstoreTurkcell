using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen yayınevi ismini giriniz!")]
        [Display(Name = "Yayınevinin İsmi")]
        public string Name { get; set; }

        [Display(Name = "Yayınevi Açıklaması")]
        public string Description { get; set; }

        public IList<Book> Books { get; set; }
    }
}
