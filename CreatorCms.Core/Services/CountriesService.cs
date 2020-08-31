using CreatorCms.Core.Services.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreatorCms.Core.Services
{
    public class CountriesService
    {
        private const string RapidapiHost = "restcountries-v1.p.rapidapi.com";
        private const string RapidapiKey = "75d4248cc5msh98b980e86f79fe8p1d703fjsn9569090dd601";

        public async Task<List<CountryResponse>> GetAllCountries()
        {
            RestClient client = new RestClient("https://restcountries-v1.p.rapidapi.com/all");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", RapidapiHost);
            request.AddHeader("x-rapidapi-key", RapidapiKey);
            List<CountryResponse> response = await client.GetAsync<List<CountryResponse>>(request);

            return response;
        }
    }
}
