using System;
using System.Collections.Generic;

namespace bookStoreTurkcell.Models.Services.FakeServices
{
    public class FakeBookService : IBookService
    {
        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{ID=1, Name="Bilgiyle Sohbet", Rating=5, Description="Bilgilendirici", Price=50.70M ,Discount=0.35, SupplyTime=2, ISBN=9786053609728, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2013, 06, 01), PageNumber=756, ImageUrl="https://i.dr.com.tr/cache/500x400-0/originals/0000000577576-1.jpg"},
                new Book{ID=2, Name="Zamanın Çocukları", Rating=4, Description="Muazzam", Price=43.23M ,Discount=0.3, SupplyTime=4, OriginalName="Children of Time", ISBN=9786053609729, CoverType="Kağıt Kapak", Dimensions="15 X 21", PublishDate=new DateTime(2015, 03, 01), PageNumber=578, ImageUrl="https://i.idefix.com/cache/600x600-0/originals/0001890533001-1.jpg"},
                new Book{ID=3, Name="Cenazeden Sonra", Rating=3, Description="Heyecanlı", Price=18.9M ,Discount=0.2, SupplyTime=3, OriginalName="Funerals are Fatal",ISBN=9786053609730, CoverType="Kağıt Kapak", Dimensions="13.5 X 19.5", PublishDate= new DateTime(2019, 10, 01), PageNumber=177, ImageUrl="http://www.altinkitaplar.com.tr/static/img/2020/06/cenazeden-sonra2-m.jpg"},
                new Book{ID=4, Name="Huzur", Rating=4, Description="Üzücü", Price=20.45M ,Discount=0.2, SupplyTime=2, ISBN=9786053609731, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2018, 08, 01), PageNumber=394, ImageUrl="https://i.idefix.com/cache/600x600-0/originals/0000000067770-1.jpg"},
                new Book{ID=5, Name="Swamp Thing Efsanesi 1. Cilt", Rating=3.5, Description="İlginç", Price=35.5M ,Discount=0.35, SupplyTime=1, OriginalName="Saga of the Swamp Thing: Book One",ISBN=9786053609732, CoverType="Ciltsiz", Dimensions="15 X 25", PublishDate=new DateTime(2020, 12, 01), PageNumber=201, ImageUrl="https://cdn.kidega.com/product-images-opt/publication/97/86/25/9786257913904.png?v=2020-08-31-14"},
                new Book{ID=6, Name="Yabancı", Rating=4.75, Description="Garip", Price=15.35M ,Discount=0.3, SupplyTime=2, OriginalName="L'Etranger",ISBN=9786053609733, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate= new DateTime(2019, 05, 01), PageNumber=182, ImageUrl="https://i.dr.com.tr/cache/500x400-0/originals/0000000064464-1.jpg"},
                new Book{ID=7, Name="Cesur Yeni Dünya", Rating=4.5, Description="Değişik", Price=30.35M ,Discount=0.35, SupplyTime=2, OriginalName="Brave New World",ISBN=9786053609734, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2021, 01, 01), PageNumber=378, ImageUrl= "https://lh3.googleusercontent.com/proxy/aKW7aEETjqJQ407pY8FrWdqmqzNF2i8JNwaNv7fgVlMkE9PbCUD5LH7cQBE6M2xHh86XRKNySv4UtdBuZzUPp8XJkBQMi4Irc7mdyxwmqsZitZvIe1X92oRBW6qKly0I" },
                new Book{ID=8, Name="Bilgiyle Sohbet", Rating=5, Description="Bilgilendirici", Price=50.70M ,Discount=0.35, SupplyTime=2, ISBN=9786053609728, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2013, 06, 01), PageNumber=756, ImageUrl="https://i.dr.com.tr/cache/500x400-0/originals/0000000577576-1.jpg"},
                new Book{ID=9, Name="Zamanın Çocukları", Rating=4, Description="Muazzam", Price=43.23M ,Discount=0.3, SupplyTime=4, OriginalName="Children of Time", ISBN=9786053609729, CoverType="Kağıt Kapak", Dimensions="15 X 21", PublishDate=new DateTime(2015, 03, 01), PageNumber=578, ImageUrl="https://i.idefix.com/cache/600x600-0/originals/0001890533001-1.jpg"},
                new Book{ID=10, Name="Cenazeden Sonra", Rating=3, Description="Heyecanlı", Price=18.9M ,Discount=0.2, SupplyTime=3, OriginalName="Funerals are Fatal",ISBN=9786053609730, CoverType="Kağıt Kapak", Dimensions="13.5 X 19.5", PublishDate=new DateTime(2019, 10, 01), PageNumber=177, ImageUrl="http://www.altinkitaplar.com.tr/static/img/2020/06/cenazeden-sonra2-m.jpg"},
                new Book{ID=11, Name="Huzur", Rating=4, Description="Üzücü", Price=20.45M ,Discount=0.2, SupplyTime=2, ISBN=9786053609731, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2018, 08, 01), PageNumber=394, ImageUrl="https://i.idefix.com/cache/600x600-0/originals/0000000067770-1.jpg"},
                new Book{ID=12, Name="Swamp Thing Efsanesi 1. Cilt", Rating=3.5, Description="İlginç", Price=35.5M ,Discount=0.35, SupplyTime=1, OriginalName="Saga of the Swamp Thing: Book One",ISBN=9786053609732, CoverType="Ciltsiz", Dimensions="15 X 25", PublishDate=new DateTime(2020, 12, 01), PageNumber=201, ImageUrl="https://cdn.kidega.com/product-images-opt/publication/97/86/25/9786257913904.png?v=2020-08-31-14"},
                new Book{ID=13, Name="Yabancı", Rating=4.75, Description="Garip", Price=15.35M ,Discount=0.3, SupplyTime=2, OriginalName="L'Etranger",ISBN=9786053609733, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2019, 05, 01), PageNumber=182, ImageUrl="https://i.dr.com.tr/cache/500x400-0/originals/0000000064464-1.jpg"},
                new Book{ID=14, Name="Cesur Yeni Dünya", Rating=4.5, Description="Değişik", Price=30.35M ,Discount=0.35, SupplyTime=2, OriginalName="Brave New World",ISBN=9786053609734, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2021, 01, 01), PageNumber=378, ImageUrl= "https://lh3.googleusercontent.com/proxy/aKW7aEETjqJQ407pY8FrWdqmqzNF2i8JNwaNv7fgVlMkE9PbCUD5LH7cQBE6M2xHh86XRKNySv4UtdBuZzUPp8XJkBQMi4Irc7mdyxwmqsZitZvIe1X92oRBW6qKly0I" },
                new Book{ID=15, Name="Bilgiyle Sohbet", Rating=5, Description="Bilgilendirici", Price=50.70M ,Discount=0.35, SupplyTime=2, ISBN=9786053609728, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2013, 06, 01), PageNumber=756, ImageUrl="https://i.dr.com.tr/cache/500x400-0/originals/0000000577576-1.jpg"},
                new Book{ID=16, Name="Zamanın Çocukları", Rating=4, Description="Muazzam", Price=43.23M ,Discount=0.3, SupplyTime=4, OriginalName="Children of Time", ISBN=9786053609729, CoverType="Kağıt Kapak", Dimensions="15 X 21", PublishDate=new DateTime(2015, 03, 01), PageNumber=578, ImageUrl="https://i.idefix.com/cache/600x600-0/originals/0001890533001-1.jpg"},
                new Book{ID=17, Name="Cenazeden Sonra", Rating=3, Description="Heyecanlı", Price=18.9M ,Discount=0.2, SupplyTime=3, OriginalName="Funerals are Fatal",ISBN=9786053609730, CoverType="Kağıt Kapak", Dimensions="13.5 X 19.5", PublishDate=new DateTime(2019, 10, 01), PageNumber=177, ImageUrl="http://www.altinkitaplar.com.tr/static/img/2020/06/cenazeden-sonra2-m.jpg"},
                new Book{ID=18, Name="Huzur", Rating=4, Description="Üzücü", Price=20.45M ,Discount=0.2, SupplyTime=2, ISBN=9786053609731, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2018, 08, 01), PageNumber=394, ImageUrl="https://i.idefix.com/cache/600x600-0/originals/0000000067770-1.jpg"},
                new Book{ID=19, Name="Swamp Thing Efsanesi 1. Cilt", Rating=3.5, Description="İlginç", Price=35.5M ,Discount=0.35, SupplyTime=1, OriginalName="Saga of the Swamp Thing: Book One",ISBN=9786053609732, CoverType="Ciltsiz", Dimensions="15 X 25", PublishDate=new DateTime(2020, 12, 01), PageNumber=201, ImageUrl="https://cdn.kidega.com/product-images-opt/publication/97/86/25/9786257913904.png?v=2020-08-31-14"},
                new Book{ID=20, Name="Yabancı", Rating=4.75, Description="Garip", Price=15.35M ,Discount=0.3, SupplyTime=2, OriginalName="L'Etranger",ISBN=9786053609733, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2019, 05, 01), PageNumber=182, ImageUrl="https://i.dr.com.tr/cache/500x400-0/originals/0000000064464-1.jpg"},
                new Book{ID=21, Name="Cesur Yeni Dünya", Rating=4.5, Description="Değişik", Price=30.35M ,Discount=0.35, SupplyTime=2, OriginalName="Brave New World",ISBN=9786053609734, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2021, 01, 01), PageNumber=378, ImageUrl= "https://lh3.googleusercontent.com/proxy/aKW7aEETjqJQ407pY8FrWdqmqzNF2i8JNwaNv7fgVlMkE9PbCUD5LH7cQBE6M2xHh86XRKNySv4UtdBuZzUPp8XJkBQMi4Irc7mdyxwmqsZitZvIe1X92oRBW6qKly0I" },
                new Book{ID=22, Name="Bilgiyle Sohbet", Rating=5, Description="Bilgilendirici", Price=50.70M ,Discount=0.35, SupplyTime=2, ISBN=9786053609728, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2013, 06, 01), PageNumber=756, ImageUrl="https://i.dr.com.tr/cache/500x400-0/originals/0000000577576-1.jpg"},
                new Book{ID=23, Name="Zamanın Çocukları", Rating=4, Description="Muazzam", Price=43.23M ,Discount=0.3, SupplyTime=4, OriginalName="Children of Time", ISBN=9786053609729, CoverType="Kağıt Kapak", Dimensions="15 X 21", PublishDate=new DateTime(2015, 03, 01), PageNumber=578, ImageUrl="https://i.idefix.com/cache/600x600-0/originals/0001890533001-1.jpg"},
                new Book{ID=24, Name="Cenazeden Sonra", Rating=3, Description="Heyecanlı", Price=18.9M ,Discount=0.2, SupplyTime=3, OriginalName="Funerals are Fatal",ISBN=9786053609730, CoverType="Kağıt Kapak", Dimensions="13.5 X 19.5", PublishDate=new DateTime(2019, 10, 01), PageNumber=177, ImageUrl="http://www.altinkitaplar.com.tr/static/img/2020/06/cenazeden-sonra2-m.jpg"},
                new Book{ID=25, Name="Huzur", Rating=4, Description="Üzücü", Price=20.45M ,Discount=0.2, SupplyTime=2, ISBN=9786053609731, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2018, 08, 01), PageNumber=394, ImageUrl="https://i.idefix.com/cache/600x600-0/originals/0000000067770-1.jpg"},
                new Book{ID=26, Name="Swamp Thing Efsanesi 1. Cilt", Rating=3.5, Description="İlginç", Price=35.5M ,Discount=0.35, SupplyTime=1, OriginalName="Saga of the Swamp Thing: Book One",ISBN=9786053609732, CoverType="Ciltsiz", Dimensions="15 X 25", PublishDate=new DateTime(2020, 12, 01), PageNumber=201, ImageUrl="https://cdn.kidega.com/product-images-opt/publication/97/86/25/9786257913904.png?v=2020-08-31-14"},
                new Book{ID=27, Name="Yabancı", Rating=4.75, Description="Garip", Price=15.35M ,Discount=0.3, SupplyTime=2, OriginalName="L'Etranger",ISBN=9786053609733, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2019, 05, 01), PageNumber=182, ImageUrl="https://i.dr.com.tr/cache/500x400-0/originals/0000000064464-1.jpg"},
                new Book{ID=28, Name="Cesur Yeni Dünya", Rating=4.5, Description="Değişik", Price=30.35M ,Discount=0.35, SupplyTime=2, OriginalName="Brave New World",ISBN=9786053609734, CoverType="Kağıt Kapak", Dimensions="13.5 X 21", PublishDate=new DateTime(2021, 01, 01), PageNumber=378, ImageUrl= "https://lh3.googleusercontent.com/proxy/aKW7aEETjqJQ407pY8FrWdqmqzNF2i8JNwaNv7fgVlMkE9PbCUD5LH7cQBE6M2xHh86XRKNySv4UtdBuZzUPp8XJkBQMi4Irc7mdyxwmqsZitZvIe1X92oRBW6qKly0I" },







            };
        }

        public List<Book> GetBooksByGenreID(int genreID)
        {
            throw new NotImplementedException();
        }
    }
}
