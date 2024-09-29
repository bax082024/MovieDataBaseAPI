using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MovieDatabaseAPI.Controllers
{
    [Route("v1/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<string> Movies = new List<string> { "The Matrix", "Interstellar" };

        // GET: v1/movies
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAllMovies()
        {
            return Movies;
        }

        // POST: v1/movies/add/{movieName}
        [HttpPost("add/{movieName}")]
        public IActionResult AddMovie(string movieName)
        {
            Movies.Add(movieName);
            return CreatedAtAction(nameof(GetAllMovies), new { name = movieName }, movieName);
        }

        // DELETE: v1/movies/delete/{movieName}
        [HttpDelete("delete/{movieName}")]
        public IActionResult DeleteMovie(string movieName)
        {
            var movie = Movies.FirstOrDefault(m => m == movieName);
            if (movie == null)
            {
                return NotFound();
            }
            Movies.Remove(movie);
            return NoContent();
        }
    }
}
