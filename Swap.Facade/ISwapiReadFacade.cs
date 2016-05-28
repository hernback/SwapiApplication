using Swapi.Client.Model;
using System.Collections.Generic;

namespace Swap.Facade
{
    public interface ISwapiReadFacade
    {
        List<Film> GetFilms();
        List<People> GetPeople();
    }
}