using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using bookStoreTurkcell.Services;

namespace bookStoreTurkcell.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private IGenreService genreService;
        private IAuthorService authorService;
        private IPublisherService publisherService;

        public MenuViewComponent(IGenreService genreService, IPublisherService publisherService, IAuthorService authorService)
        {
            this.genreService = genreService;
            this.authorService = authorService;
            this.publisherService = publisherService;
        }
        public IViewComponentResult Invoke() 
        {
            dynamic menuModel = new ExpandoObject();
            menuModel.Genres = genreService.GetGenres();
            menuModel.Authors = authorService.GetAuthors();
            menuModel.Publishers = publisherService.GetPublishers();
            return View(menuModel);
        
        }


    }
}
