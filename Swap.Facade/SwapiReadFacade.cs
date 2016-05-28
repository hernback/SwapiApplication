using Swapi.Client;
using Swapi.Client.Model;
using System.Collections.Generic;
using System;

namespace Swap.Facade
{
    public class SwapiReadFacade : ISwapiReadFacade
    {
        private SwapiClient _client;

        public SwapiReadFacade()
        {
            _client = new SwapiClient();
        }

        public List<Film> GetFilms()
        {
            return _client.GetFilms();
        }

        public List<People> GetPeople()
        {
            return _client.GetPeople();
        }
    }
}
