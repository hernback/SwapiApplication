using Swapi.Client.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Swapi.Client
{
    public class SwapiClient
    {
        public const string BaseAddress = "http://swapi.co";
        public const string FilmUrl = "/api/films/";
        public const string PeopleUrl = "/api/people/";

        public List<Film> GetFilms()
        {
            var json = HttpClientHelper.RunHttpClientSyncCall(BaseAddress, FilmUrl);

            var response = JsonConvert.DeserializeObject<FilmResponse>(json);

            return response.results;
        }

        public List<People> GetPeople()
        {
            var json = HttpClientHelper.RunHttpClientSyncCall(BaseAddress, PeopleUrl);

            var response = JsonConvert.DeserializeObject<PeopleResponse>(json);

            return response.results;
        }

        //public Film GetFilm(int episodeId)
        //{
        //    var json = HttpClientHelper.RunHttpClientSyncCall(BaseAddress, FilmUrl + episodeId + "/");

        //    var response = JsonConvert.DeserializeObject<Film>(json);

        //    return response;
        //}
    }
}
