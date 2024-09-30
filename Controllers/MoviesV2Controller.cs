using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using MovieDataBaseAPI.controllers;
namespace MovieDatabaseAPI.Controllers
{
  [ApiController]
  [Route("v2/movies")]
  public class MoviesV2Controller : ControllerBase
  {
    private static List<Movie> movies = new List<Movie>
    {
      new Movie("The Matrix", "136 min"),
      new Movie("Interstellar", "169 min"),
      new Movie("Spongebob", "90 min")
    };

    // Get all movies with detail
    [HttpGet]
    public IActionResult GetAllMovies()
    {
     // return Ok(movies.Select(m => new {Movie = m,}));
     return Ok(movies);
    }


    // Add Movie
    [HttpPost("add")]
    public IActionResult AddMovie(string title, string lenght)
    {
      if (!movies.Any(m => m.Title == title))
      {
        movies.Add(new Movie(title, lenght ));
        return CreatedAtAction(nameof(GetAllMovies), new {title});
      }
      return BadRequest("Movie allready exists.");
    }

    // Delete Movie
    [HttpDelete("delete/{title}")]
    public IActionResult DeleteMovie(string title)
    {
      var movie = movies.FirstOrDefault(m => m.Title == title);
      if (movie != null)
      {
        movies.Remove(movie);
        return NoContent();
      }
      return NotFound("Movie not found");
      
    }
  }
}