using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using bookStoreTurkcell.Models.Services;

namespace bookStoreTurkcell.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private IGenreService genreService;
        

        public MenuViewComponent(IGenreService genreService)
        {
            this.genreService = genreService;
           

        }
        public IViewComponentResult Invoke() 
        {
            var genres = genreService.GetGenres();
            return View(genres);
        
        }


    }
}
