using Swapi.Client.Model;
using System.Collections.Generic;

namespace SwapiApplication.ViewModels.Starwars
{
    public class FilmViewModel
    {
        public Film Film { get; set; }
        public List<People> People { get;set; }
    }
}