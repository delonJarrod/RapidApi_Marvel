using Microsoft.AspNetCore.Mvc;
using RapidApi_Marvel.Interface;
using RapidApi_Marvel.Models;

namespace RapidApi_Marvel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarvelVsCapcomController : ControllerBase
    {
        private readonly IMarvelVsCapcom _marvelVsCapcom;

        public MarvelVsCapcomController(IMarvelVsCapcom marvelVsCapcom)
        {
            _marvelVsCapcom = marvelVsCapcom;
        }
        [HttpGet]
        [Route("get_Characters")]
        public async Task<ActionResult<IEnumerable<Character>>> getCharacters()
        {
            return Ok(await _marvelVsCapcom.getCharacters());
        }

        [HttpPost]
        [Route("post_Show_Character")]
        public async Task<ActionResult<IEnumerable<Character>>> postShowCharacter(string name)
        {
            return Ok(await _marvelVsCapcom.postShowCharacter(name));
        }
    }
}
