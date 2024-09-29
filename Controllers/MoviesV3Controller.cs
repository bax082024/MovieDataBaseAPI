using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace MovieDatabaseAPI.Controllers
{
  [ApiController]
  [Route("v3/movies")]
  public class MoviesV3Controller : ControllerBase
  {
    private static List<string> movies = new List<string>
    {
      "The Matrix", "Interstellar", "Spongebob", "Mr.Bean"
    };

    // Get movie detail by name
    public IActionResult GetMovieByTitle(string title)
    {
      var movie = movies.FirstOrDefault(m => m.Equals(title, System.StringComparison.OrdinalIgnoreCase));
      if (movie == null)
        return NotFound();

      // Here you can return more detailed information about the movie
      return Ok(new{ Title = movie, Lenght = "N/A", Director = "unknown"});


    }


    // Add movie
    [HttpPost("add/{title}")]
    public IActionResult AddMovie(string title)
    {
      if (!movies.Contains(title))
      {
        movies.Add(title);
        return CreatedAtAction(nameof(GetMovieByTitle), new {title});
      }
      return BadRequest("Movie already exists");
    }


    // Delete movie
    [HttpDelete("delete/{title}")]
    public IActionResult DeleteMovies(string title)
    {
      if (movies.Remove(title))
      {
        return NoContent();
      }
      return NotFound();
    }


  }


}