using CreatorCms.Core.Services.Models;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
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
            List<CountryResponse> response = await GetResponse<List<CountryResponse>>("all");

            return response;
        }

        private static async Task<T> GetResponse<T>(string url)
        {
            RestClient client = new RestClient("https://restcountries-v1.p.rapidapi.com/" + url);
            client.UseNewtonsoftJson();
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", RapidapiHost);
            request.AddHeader("x-rapidapi-key", RapidapiKey);
            IRestResponse<T> response = await client.ExecuteAsync<T>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }

            //TODO: log error

            return default;
        }
    }
}
