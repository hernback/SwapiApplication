using System.Collections.Generic;

namespace Swapi.Client.Model
{
    public class Film
    {
        public List<string> characters { get; set; }
        public string created { get; set; }
        public string director { get; set; }
        public string edited { get; set; }
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }
        public List<string> planets { get; set; }
        public string producer { get; set; }
        public string release_date { get; set; }
        public List<string> species { get; set; }
        public List<string> starships { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public List<string> vehicles { get; set; }
    }
}
