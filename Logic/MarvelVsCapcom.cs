using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi_Marvel.Interface;
using RapidApi_Marvel.Models;
using System;
using System.Net.Http;

namespace RapidApi_Marvel.Logic
{
    public class MarvelVsCapcom : IMarvelVsCapcom
    {

        private readonly HttpClient _httpClient = new HttpClient();    

        public async Task<List<Character>> getCharacters()
        {
            var response = await GetMethod("https://marvel-vs-capcom-2.p.rapidapi.com/characters");
            List<Character> characters = JsonConvert.DeserializeObject<List<Character>>(response);
            return characters;
        }

        public async Task<Character> postShowCharacter(string name)
        {
            var response = await GetMethod("https://marvel-vs-capcom-2.p.rapidapi.com/characters/"+name);
            List<Character> characterList = JsonConvert.DeserializeObject<List<Character>>(response);
            Character character = characterList.FirstOrDefault()
;           return character;
        }

        public async Task<string> GetMethod(string url)
        {
            // Getting the weather data
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("X-RapidAPI-Key", "1dcecfd511msha78bd4104e04264p11ee1fjsnf767f971b342");
            request.Headers.Add("X-RapidAPI-Host", "marvel-vs-capcom-2.p.rapidapi.com");
            using var response = await _httpClient.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            return body;
        }
    }
}
