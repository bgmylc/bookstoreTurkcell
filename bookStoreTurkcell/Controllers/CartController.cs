using bookStoreTurkcell.Models;
using bookStoreTurkcell.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Controllers
{
    public class CartController : Controller
    {
        private IBookService bookService;

        public CartController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        public IActionResult Index(string returnURL)
        {
            var cart = GetCart();
            ViewBag.ReturnURL = returnURL;
            return View(cart);
        }

        [HttpPost]
        public IActionResult AddToCart(int bookID, string returnURL)
        {
            var selectedBook = bookService.GetBookByID(bookID);
            if (selectedBook == null)
            {
                return NotFound();
            }

            Cart cart = GetCart() ?? new Cart();
            cart.AddItem(selectedBook, 1);
            SaveCart(cart);

            return RedirectToAction(nameof(Index), nameof(Cart), new { returnURL = returnURL});
        }

        Cart GetCart()
        {
            var data = HttpContext.Session.GetString("My Cart");
            if (data == null)
            {
                return null;
            }
            else
            {
               return JsonConvert.DeserializeObject<Cart>(data);
            }
        }

        void SaveCart(Cart cart)
        {
            HttpContext.Session.SetString("My Cart", JsonConvert.SerializeObject(cart));
        }

        public IActionResult Delete(int ID)
        {
            var cart = GetCart(); 
            var deleteBook = bookService.GetBookByID(ID);
            cart.Remove(deleteBook);
            SaveCart(cart);

            return RedirectToAction(nameof(Index), nameof(Cart));
        }

    }
}
