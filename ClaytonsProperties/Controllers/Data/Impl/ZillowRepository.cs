using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace ClaytonsProperties.Controllers.Data.Impl
{
    public class ZillowRepository : IZillowRepository
    {
        private static string baseUrl = "";

        public async Task<object> GetPropertyAsync(int property)
        {
            var userString = await GetStringAsync(baseUrl + "properties/" + property);
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
            var user = JsonConvert.DeserializeObject<object>(userString);
            return user;
        }

        private static async Task<string> GetStringAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(url);
            }
        }
    }
}