using RapidApi_Marvel.Models;

namespace RapidApi_Marvel.Interface
{
    public interface IMarvelVsCapcom
    {
        public Task<List<Character>> getCharacters();
        public Task<Character> postShowCharacter(string name);
    }
}
