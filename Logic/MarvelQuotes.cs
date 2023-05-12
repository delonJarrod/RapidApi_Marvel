using Newtonsoft.Json;
using RapidApi_Marvel.Interface;
using RapidApi_Marvel.Models;
using System;

namespace RapidApi_Marvel.Logic
{
    public class MarvelQuotes : IMarvelQuotes
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        public async Task<Quotes> getMarvelQuotes()
        {

            var response = await GetMethod("https://marvel-quote-api.p.rapidapi.com/");
            Quotes quote = JsonConvert.DeserializeObject<Quotes>(response);
            return quote;
        }


        public async Task<string> GetMethod(string url)
        {
            // Getting the weather data
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("X-RapidAPI-Key", "1dcecfd511msha78bd4104e04264p11ee1fjsnf767f971b342");
            request.Headers.Add("X-RapidAPI-Host", "marvel-quote-api.p.rapidapi.com");
            using var response = await _httpClient.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            return body;
        }
    }
}
