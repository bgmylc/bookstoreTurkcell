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
            
            if (publisherService.DoesPubExist(publisher))
            {
                ViewBag.Message = 0;
                return View();
            }
            else if (ModelState.IsValid) //If there are no errors; add the publisher and return to the list
            {
                publisherService.AddPublisher(publisher);
                return RedirectToAction(nameof(Index));
            }
            return View(); //If there is an error open the same view again
        }

        public IActionResult Edit(int pubID)
        {
            var publisher = publisherService.GetPublisherByID(pubID);

            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }

        [HttpPost]
        public IActionResult Edit(Publisher publisher)
        {
            if (ModelState.IsValid)
            {

                publisherService.UpdatePublisher(publisher);
                return RedirectToAction(nameof(Index));
            }

            return View(publisher);
        }

        public IActionResult Delete(int pubID)
        {
            var publisher = publisherService.GetPublisherByID(pubID);

            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }

        [HttpPost]
        public IActionResult Delete(Publisher publisher)
        {
            if (publisherService.pubBook(publisher.ID))
            {
                ViewBag.Message = 0;
                return View(publisher);
            }
            publisherService.DeletePublisher(publisher);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Details(int pubID)
        {
            var publisher = publisherService.GetPublisherByID(pubID);

            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }
    }
}
