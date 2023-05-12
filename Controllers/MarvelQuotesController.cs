using Microsoft.AspNetCore.Mvc;
using RapidApi_Marvel.Interface;
using RapidApi_Marvel.Models;

namespace RapidApi_Marvel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarvelQuotesController : ControllerBase
    {
        private readonly IMarvelQuotes _marvelQuotes;

        public MarvelQuotesController(IMarvelQuotes marvelQuotes)
        {
            _marvelQuotes = marvelQuotes;
        }

        [HttpGet]
        [Route("get_Marvel_Quote")]
        public async Task<ActionResult<IEnumerable<Quotes>>> getMarvelQuotes()
        {
            return Ok(await _marvelQuotes.getMarvelQuotes());
        }
    }
}
