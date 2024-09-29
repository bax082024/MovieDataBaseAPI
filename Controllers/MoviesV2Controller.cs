using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MovieDatabaseAPI.Controllers
{
  [ApiController]
  [Route("v2/movies")]
  public class MoviesV2Controller : ControllerBase
  {
    private static List<string> movies = new List<string>
    {
      "The Matrix", "Interstellar", "Spongebob"
    };

    // Get all movies with detail
    [HttpGet]
    public IActionResult GetAllMovies()
    {
      return Ok(movies.Select(m => new {Title = m, Lenght = "N/A"}));
    }


    // Add Movie
    [HttpPost("add/title")]
    public IActionResult AddMovie(string title)
    {
      if (!movies.Contains(title))
      {
        movies.Add(title);
        return CreatedAtAction(nameof(GetAllMovies), new {title});
      }
      return BadRequest("Movie allready exists.");
    }

    // Delete Movie
    [HttpDelete("delete/{title}")]
    public IActionResult DeleteMovie(string title)
    {
      if (movies.Remove(title))
      {
        return NoContent();
      }
      return NoContent();
    }
  }
}