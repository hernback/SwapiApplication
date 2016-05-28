using Swapi.Client.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Swap.Facade
{
    public class CachedSwapReadFacade : ISwapiReadFacade
    {
        private SwapiReadFacade _facade;

        public CachedSwapReadFacade()
        {
            _facade = new SwapiReadFacade();
        }

        public List<Film> GetFilms()
        {
            var cacheKey = "GetFilms";

            if(HttpRuntime.Cache[cacheKey] != null)
            {
                return HttpRuntime.Cache[cacheKey] as List<Film>;
            }

            var films = _facade.GetFilms();

            HttpRuntime.Cache[cacheKey] = films;

            return films;
        }

        public Film GetFilm(int id)
        {
            var films = GetFilms();

            return films.FirstOrDefault(film => film.episode_id == id);
        }

        public List<People> GetPeople()
        {
            var cacheKey = "GetPeople";

            if (HttpRuntime.Cache[cacheKey] != null)
            {
                return HttpRuntime.Cache[cacheKey] as List<People>;
            }

            var people = _facade.GetPeople().OrderBy(p => p.name);

            HttpRuntime.Cache[cacheKey] = people;

            return people;
        }

        public List<People> GetPeopleByNames(List<string> names)
        {
            return GetPeople().Where(people => names.Contains(people.name)).Select(people => people).ToList();
        }

        public List<People> GetPeopleByResourceUrl(List<string> urls)
        {
            return GetPeople().Where(people => urls.Contains(people.url)).Select(people => people).ToList();
        }
    }
}
