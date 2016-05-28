using System.Collections.Generic;

namespace Swapi.Client.Model
{
    public class PeopleResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<People> results { get; set; }
    }
}
