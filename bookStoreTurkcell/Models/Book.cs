using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models
{
    public class Book
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Lütfen kitap ismini giriniz!")]
        [Display(Name = "Kitabın Adı")]
        public string Name { get; set; }
       
        [Display(Name = "Kitabın Derecelendirmesi")]
        public double? Rating { get; set; }
        
        [Required(ErrorMessage = "Lütfen kitap açıklamasını giriniz!")]
        [Display(Name = "Kitabın Açıklaması")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Lütfen kitabın fiyatını giriniz!")]
        [Display(Name = "Kitabın Fiyatı")]
        public decimal Price { get; set; }
       
        [Required(ErrorMessage = "Lütfen indirim oranını giriniz!")]
        [Display(Name = "Kitabın İndirim Oranı")]
        public double? Discount { get; set; }
        
        [Required(ErrorMessage = "Lütfen tedarik süresini giriniz!")]
        [Display(Name = "Kitabın Tedarik Süresi")]
        public int? SupplyTime { get; set; }

        [Display(Name = "Kitabın (Varsa) Orijinal Adı")]
        public string OriginalName { get; set; }
        
        [Required(ErrorMessage = "Lütfen kitabın ISBN numarasını giriniz!")]
        [Display(Name = "Kitabın ISBN Numarası")]
        [StringLength(13, MinimumLength =13,ErrorMessage ="ISBN 13 Haneli olmalıdır!")]
        public string ISBN { get; set; }
        
        [Required(ErrorMessage = "Lütfen kitabın kapak türünü giriniz!")]
        [Display(Name = "Kitabın Kapak Türü")]
        public string CoverType { get; set; }

        [Display(Name = "Kitabın Boyutları")]
        public string Dimensions { get; set; }
        
        [Required(ErrorMessage = "Lütfen kitabın basım tarihini giriniz!")]
        [DisplayFormat(DataFormatString = "{0:MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? PublishDate { get; set; }
        
        [Required(ErrorMessage = "Lütfen kitabın sayfa sayısını giriniz!")]
        [Display(Name = "Kitabın Sayfa Sayısı")]
        public int? PageNumber { get; set; }

        [Display(Name = "Kitabın Resim URL'si")]
        public string ImageUrl { get; set; }
        
        [Required(ErrorMessage = "Lütfen kitabın yazarını seçiniz!")]
        [Display(Name = "Kitabın Yazarı")]
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        
        [Required(ErrorMessage = "Lütfen kitabın yayınevini seçiniz!")]
        [Display(Name = "Kitabın Yayınevi")]
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }
       
        [Required(ErrorMessage = "Lütfen kitabın türünü seçiniz!")]
        [Display(Name = "Kitabın Türü")]
        public int GenreID { get; set; }
        public Genre Genre { get; set; }







    }
}
