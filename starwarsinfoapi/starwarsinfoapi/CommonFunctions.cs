using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace starwarsinfoapi.Controllers
{
    public class CommonFunctions
    {
        private readonly string swapiUrl = "https://swapi.dev/api";

        private string RequestData(string url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resultText = streamReader.ReadToEnd();
                return resultText;
            }
        }

        public T GetSingleByUrl<T>(string url)
        {
            string json = RequestData(swapiUrl + url);
            T entity = JsonConvert.DeserializeObject<T>(json);
            return entity;
        }
    }
}