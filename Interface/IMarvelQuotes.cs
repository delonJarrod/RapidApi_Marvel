using RapidApi_Marvel.Models;

namespace RapidApi_Marvel.Interface
{
    public interface IMarvelQuotes
    {
        public Task<Quotes> getMarvelQuotes();
    }
}
