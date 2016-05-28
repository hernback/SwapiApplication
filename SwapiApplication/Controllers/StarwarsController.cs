using Swap.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwapiApplication.Controllers
{
    public class StarwarsController : Controller
    {
        public ActionResult Films()
        {
            var model = new ViewModels.Starwars.FilmsViewModel();
            var facade = new CachedSwapReadFacade();

            var films = facade.GetFilms();
            
            if(films != null)
            {
                films = films.OrderBy(x => x.episode_id).ToList();
            }
            
            model.AvailableFilms = films;

            return View("/Views/Starwars/Films.cshtml", model);
        }

        public ActionResult Film(int id)
        {
            var model = new ViewModels.Starwars.FilmViewModel();
            var facade = new CachedSwapReadFacade();

            model.Film = facade.GetFilm(id);
            model.People = facade.GetPeopleByResourceUrl(model.Film.characters);

            return View("/Views/Starwars/Film.cshtml", model);
        }

        public ActionResult People(string name)
        {
            var model = new ViewModels.Starwars.PeopleViewModel();
            var facade = new CachedSwapReadFacade();

            model.People = facade.GetPeopleByNames(new List<string> { name }).FirstOrDefault();

            return View("/Views/Starwars/People.cshtml", model);
        }
    }
}