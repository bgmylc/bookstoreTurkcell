using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Models
{
    public class Cart
    {
        private List<CartLine> cartLines = new List<CartLine>();
        public void AddItem(Book book, int quantity)
        {
            var existingLine = cartLines.FirstOrDefault(b => b.Book.ID == book.ID);
            if (existingLine == null)
            {
                cartLines.Add(new CartLine { Book = book, Quantity = quantity });
            }
            else
            {
                existingLine.Quantity += quantity;
            }
        }

        public void Remove(Book book) => cartLines.RemoveAll(c => c.Book.ID == book.ID);

        public void Clear() => cartLines.Clear();

        public decimal GetTotalValue() => cartLines.Sum(s => (s.Book.Price*(decimal)(1 - s.Book.Discount)) * s.Quantity);

        public IEnumerable<CartLine> CartLines => cartLines;



    }
}
