using bookStoreTurkcell.Models;
using bookStoreTurkcell.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStoreTurkcell.Controllers
{
    public class PublishersController : Controller
    {
        private IPublisherService publisherService;

        public PublishersController(IPublisherService publisherService)
        {
            this.publisherService = publisherService;
        }
        public IActionResult Index()
        {
            var publishers = publisherService.GetPublishers(); //List publishers
            return View(publishers);
        }

        public IActionResult Create()
        {
            return View();
        
        }

        [HttpPost]
        public IActionResult Create(Publisher publisher)
        {
            if (ModelState.IsValid) //If there are no errors; add the publisher and return to the list
            {
                publisherService.AddPublisher(publisher);
                return RedirectToAction(nameof(Index));
            }

            return View(); //If there is an error open the same view again
        }
    }
}
