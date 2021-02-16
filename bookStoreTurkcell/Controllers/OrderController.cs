using bookStoreTurkcell.Models;
using bookStoreTurkcell.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Controllers
{
    public class OrderController : Controller
    {
        private IUserService userService;
 

        public OrderController(IUserService userService)
        {
            this.userService = userService;
      
        }

        public IActionResult Index(decimal totalValue)
        {
            ViewBag.TotalValue = totalValue;
            return View();
        }
    }
}
