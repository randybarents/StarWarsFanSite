using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using Flurl;
using Flurl.Http;
using starwarsinfoapi.Entities;

namespace starwarsinfoapi.Controllers
{
    public class CommonFunctions
    {
        private readonly string swapiUrl = "https://swapi.dev/api";

        public async Task<People> GetPerson(int id)
        {
            People person;
            dynamic response = await (swapiUrl + "/people/" + id).GetStringAsync();
            person = CreatePerson(response);
            return person;
        }

        public async Task<PeopleList> GetPeoplePaginated(int pageNumber)
        {
            PeopleList peopleList;
            dynamic response = await (swapiUrl + "/people/?page=" + pageNumber).GetStringAsync();
            peopleList = CreatePeopleList(response);
            return peopleList;

        }

        private People CreatePerson(dynamic response)
        {
            People person;
            person = JsonConvert.DeserializeObject<People>(response);
            return person;
        }

        private PeopleList CreatePeopleList(dynamic response)
        {
            PeopleList peopleList;
            peopleList = JsonConvert.DeserializeObject<PeopleList>(response);
            return peopleList;
        }
    }
}